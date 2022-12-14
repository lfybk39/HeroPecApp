using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPecApp
{
    public partial class RegistrationForm : Form
    {
        private string captchaValue = String.Empty;

        private int passwordDifficulty = 0;

        private void CheckDifficulty(string password)
        {
            passwordDifficulty = 0;
            bool containsUpperLetter = false,
                containsLowerLetter = false,
                containsDigit = false;
            foreach (var c in password)
            {
                if (Char.IsLetter(c) && Char.IsUpper(c) && containsUpperLetter == false)
                {
                    containsUpperLetter = true;
                    passwordDifficulty++;
                }
                if (Char.IsLetter(c) && Char.IsLower(c) && containsLowerLetter == false)
                {
                    containsLowerLetter = true;
                    passwordDifficulty++;
                }
                if (Char.IsDigit(c) && containsDigit == false)
                {
                    containsDigit = true;
                    passwordDifficulty++;
                }
            }
            MessageBox.Show((passwordDifficulty == 0 ? "Введите" 
                    : passwordDifficulty == 1 ? "Слабый"
                    : passwordDifficulty == 2 ? "Средний"
                    : "Сложный") + " пароль");
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = Width / 2 - 70;
            int Ypos = Height / 2 - 25;


            Brush[] colors = { Brushes.Red, Brushes.Blue, Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Black);

            //Сгенерируем текст
            captchaValue = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                captchaValue += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(captchaValue,
                         new Font("Impact", 30),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Blue,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Blue,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 8 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private static void SendEmail(User currentUser)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential
                {
                    Password = "yrzsdlzcdivsdpcd",
                    UserName = "heropeccompany@gmail.com"
                };
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;

                var msg = new MailMessage()
                {
                    Subject = "Регистрация HeroPeC",
                    Body = $"<p>Вы успешно зарегистрировались в HeroPeC!!</p>" +
                    $"<p>Ваш логин:{currentUser.Login}</p>" +
                    $"<p>Ваш пароль:{currentUser.Password}</p>" +
                    $"<img src='http://tiny.cc/mmhzuz'>",
                    From = new MailAddress("heropeccompany@gmail.com"),
                    IsBodyHtml = true,
                    BodyEncoding = Encoding.UTF8
                };

                msg.To.Add(new MailAddress(currentUser.Email));

                smtp.Send(msg);
            }
        }

        public void Registration(User user)
        {
            try
            {
                //SendEmail(new User { Login="YaViblyadok2009", Password="zZVv", Email= "pcs.91.akt@gmail.com" });
                //MessageBox.Show("Test");
                StringBuilder errors = new StringBuilder();
                if (Core.Context.Users.Any(u => u.Login == user.Login))
                {
                    errors.AppendLine("Логин уже зарегистрирован в системе.");
                }
                else if (!Regex.IsMatch(user.Login.Trim(), @"^[a-zA-Z0-9]{4,20}$") || user.Login.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный логин. Логин должен состоять из 4-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                if (!Regex.IsMatch(user.Password.Trim(), @"^[a-zA-Z0-9]{8,20}$") || user.Password.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный пароль. Пароль должен состоять из 8-20 символов, которые могут быть строчными и прописными латинского алфавита.");
                }
                if (Core.Context.Users.Any(u => u.Email == user.Email))
                {
                    errors.AppendLine("E-mail уже зарегистрирован в системе.");
                }
                if (!Regex.IsMatch(user.Email.Trim(), @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$") || user.Email.Contains(" "))
                {
                    errors.AppendLine("Пожалуйста укажите корректный E-mail.");
                }
                if (passwordTextBox.Text != confirmationPasswordTextBox.Text)
                {
                    errors.AppendLine("Введеные пароли не совпадают.");
                }
                if (errors.Length == 0)
                {
                    if (captchaTextBox.Text.ToLower() == captchaValue.ToLower())
                    {
                        Core.Context.Users.Add(user);
                        Core.Context.SaveChanges();
                        MessageBox.Show($"{loginTextBox.Text}, вы успешно зарегистрированы!");
                        SendEmail(user);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверная капча");
                    }
                }
                else
                {
                    MessageBox.Show(errors.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Login = loginTextBox.Text,
                Email = emailTextBox.Text,
                Password = passwordTextBox.Text,
                Nickname = nicknameTextBox.Text.Trim() == "" ? null : nicknameTextBox.Text,
                Phone = phoneTextBox.Text == "+7 (   )       -" ? null : phoneTextBox.Text
            };

            Registration(user);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            captchaPictureBox.Image = CreateImage(captchaPictureBox.Width, captchaPictureBox.Height);
        }

        private void changeCaptchaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            captchaPictureBox.Image = CreateImage(captchaPictureBox.Width, captchaPictureBox.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckDifficulty(passwordTextBox.Text);
        }
    }
}
