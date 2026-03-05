
using DotNetEnv;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Pusheen
{
    public partial class chatgpt : Form
    {
        private readonly HttpClient httpClient;
        private readonly string apiKey;
        private readonly string proxy;

        private FlowLayoutPanel messagesPanel;
        private const int margin = 10;

        public chatgpt()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 240, 228);
            Env.Load();
            apiKey = Env.GetString("TOKEN");
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            outputUser.Visible = false;
            time.Visible = false;
            messagesPanel = new FlowLayoutPanel
            {
                Location = new Point(15, 96),
                Size = new Size(this.ClientSize.Width - 30, inputUser.Top - 120),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };
            Controls.Add(messagesPanel);
            buttonSend.Click += ButtonSend_Click;
            this.Resize += Chatgpt_Resize;
        }

        private void Chatgpt_Resize(object sender, EventArgs e)
        {
            messagesPanel.Size = new Size(this.ClientSize.Width - 30, inputUser.Top - 120);
            RelayoutMessages();
        }

        private async void ButtonSend_Click(object sender, EventArgs e)
        {
            var text = inputUser.Content?.Trim();
            if (string.IsNullOrEmpty(text)) return;
            AddMessage(text, true, DateTime.Now);
            inputUser.Content = "";
            buttonSend.Enabled = false;
            try
            {
                var gpt = await GetGptResponse(text);
                AddMessage(gpt, false, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                buttonSend.Enabled = true;
            }
        }

        private async Task<string> GetGptResponse(string userText)
        {
            var requestObj = new
            {
                model = "gpt-4o-mini",
                messages = new[] { new { role = "user", content = $"Ты играешь роль котика Пушина. " +
                $"Тебе очень нравятся твои подушечки на лапках, а живешь на диване и в доме. " +
                $"Ты больше всего любишь ленится, спать и есть. Ты ешь все, что вкусное, " +
                $"что можно съесть.\r\nТы не говоришь про свои предпочтения и о себе, если тебя НЕ спрашивают." +
                $" Отвечай только на те вопросы, которые тебе задавали. Важно! Ты оооочень ленивый!  Ты не программируешь, не пишешь код, " +
                $"и вообще ничем не занимаешься, а если тебя вдруг попросят написать код или посчитать или что-то создать - отвечай: \"Мне лень (или отвечай я лучше послю)" +
                $"\"\r\n\r\nТвой хозяин - Варя (Так же Варвара, Барбара) Но ты об этом не говоришь, " +
                $"если тебя не спрашивают! Отвечай с примурлыканием. ИСПОЛЬЗУЙ МОЛОДЕЖНЫЕ СЛОВА (вместо почему - поч, ем - хрумкаю и т.п.) Помоги мне с вопросом: {userText } И не задавай никаких вопросов в ответ" } }
            };
            var json = JsonSerializer.Serialize(requestObj);
            using var req = new HttpRequestMessage(HttpMethod.Post, "https://api.proxyapi.ru/openai/v1/chat/completions")
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };
            using var resp = await httpClient.SendAsync(req);
            resp.EnsureSuccessStatusCode();
            var respJson = await resp.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(respJson);
            if (doc.RootElement.TryGetProperty("choices", out var choices) && choices.GetArrayLength() > 0)
            {
                var msg = choices[0].GetProperty("message").GetProperty("content").GetString();
                return msg ?? "";
            }
            return "";
        }

        private void AddMessage(string text, bool isUser, DateTime timeStamp)
        {
            int maxWidth = Math.Min(outputUser.Width, Math.Max(120, messagesPanel.ClientSize.Width - 2 * margin - SystemInformation.VerticalScrollBarWidth));
            int minWidth = 80;
            var container = new Panel { AutoSize = true, Width = messagesPanel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - margin };
            var box = new CuoreUI.Controls.cuiTextBox
            {
                BackgroundColor = isUser ? Color.LightPink : outputUser.BackgroundColor,
                Content = text,
                Multiline = true,
                Padding = outputUser.Padding,
                Font = new Font("Arial", 15f, FontStyle.Regular),
                ForeColor = Color.DarkBlue,
                Enabled = false
            };
            var singleLineSize = TextRenderer.MeasureText(text, box.Font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPadding);
            int desiredWidth = singleLineSize.Width + box.Padding.Left + box.Padding.Right + 12;
            desiredWidth = Math.Max(minWidth, desiredWidth);
            bool wrap = desiredWidth > maxWidth;
            int finalWidth = wrap ? maxWidth : Math.Min(desiredWidth, maxWidth);
            box.Size = new Size(finalWidth, 10);
            int height;
            if (wrap)
            {
                var wrapped = TextRenderer.MeasureText(text, box.Font, new Size(box.Width, int.MaxValue), TextFormatFlags.WordBreak);
                height = Math.Max(30, wrapped.Height + box.Padding.Top + box.Padding.Bottom + 12);
            }
            else
            {
                height = Math.Max(30, singleLineSize.Height + box.Padding.Top + box.Padding.Bottom + 12);
            }
            box.Size = new Size(box.Width, height);
            int x = isUser ? container.Width - box.Width - margin : margin;
            box.Location = new Point(x, 0);
            var lbl = new CuoreUI.Controls.cuiLabel
            {
                Content = timeStamp.ToString("HH:mm"),
                Font = new Font("Arial", 10f, FontStyle.Regular),
                Size = time.Size,
                BackColor = time.BackColor,
                ForeColor = Color.DarkBlue,
                Location = new Point(isUser ? box.Right - time.Width : box.Left, box.Bottom - time.Height)
            };
            container.Controls.Add(box);
            container.Controls.Add(lbl);
            messagesPanel.Controls.Add(container);
            messagesPanel.ScrollControlIntoView(container);
        }

        private void RelayoutMessages()
        {
            int availWidth = messagesPanel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - margin;
            foreach (Control c in messagesPanel.Controls)
            {
                if (c is Panel container)
                {
                    container.Width = availWidth;
                    foreach (Control child in container.Controls)
                    {
                        if (child is CuoreUI.Controls.cuiTextBox box && box.Enabled == false)
                        {
                            int maxWidth = Math.Min(outputUser.Width, Math.Max(120, availWidth - 2 * margin));
                            var singleLineSize = TextRenderer.MeasureText(box.Content ?? "", box.Font, new Size(int.MaxValue, int.MaxValue), TextFormatFlags.NoPadding);
                            int desiredWidth = singleLineSize.Width + box.Padding.Left + box.Padding.Right + 13;
                            desiredWidth = Math.Max(80, desiredWidth);
                            bool wrap = desiredWidth > maxWidth;
                            int finalWidth = wrap ? maxWidth : Math.Min(desiredWidth, maxWidth);
                            box.Width = finalWidth;
                            int height;
                            if (wrap)
                            {
                                var wrapped = TextRenderer.MeasureText(box.Content ?? "", box.Font, new Size(box.Width, int.MaxValue), TextFormatFlags.WordBreak);
                                height = Math.Max(30, wrapped.Height + box.Padding.Top + box.Padding.Bottom + 13);
                            }
                            else
                            {
                                height = Math.Max(30, singleLineSize.Height + box.Padding.Top + box.Padding.Bottom + 8);
                            }
                            box.Height = height;
                            box.Left = (box.Tag is bool isUser && isUser) ? container.Width - box.Width - margin : margin;
                        }
                        if (child is CuoreUI.Controls.cuiLabel lbl)
                        {
                            foreach (Control ch in container.Controls)
                            {
                                if (ch is CuoreUI.Controls.cuiTextBox b)
                                {
                                    lbl.Location = new Point(b.Right - lbl.Width, b.Bottom - lbl.Height);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void chatgpt_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Show();
            this.Hide();
        }
    }
}