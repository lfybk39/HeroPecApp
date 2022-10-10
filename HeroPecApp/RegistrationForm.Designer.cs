
namespace HeroPecApp
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.changeCaptchaLinkLabel = new System.Windows.Forms.LinkLabel();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.captchaPictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email*";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 25);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(127, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин*";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 64);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(127, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль*";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 103);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(127, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подтверждение пароля*";
            // 
            // confirmationPasswordTextBox
            // 
            this.confirmationPasswordTextBox.Location = new System.Drawing.Point(12, 142);
            this.confirmationPasswordTextBox.Name = "confirmationPasswordTextBox";
            this.confirmationPasswordTextBox.Size = new System.Drawing.Size(127, 20);
            this.confirmationPasswordTextBox.TabIndex = 7;
            this.confirmationPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(12, 183);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(127, 23);
            this.registrationButton.TabIndex = 8;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "* - обязательные поля";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Имя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Телефон";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(148, 25);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nicknameTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(148, 64);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTextBox.Mask = "+7 (000) 000 00-00";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 14;
            // 
            // changeCaptchaLinkLabel
            // 
            this.changeCaptchaLinkLabel.AutoSize = true;
            this.changeCaptchaLinkLabel.Location = new System.Drawing.Point(147, 154);
            this.changeCaptchaLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changeCaptchaLinkLabel.Name = "changeCaptchaLinkLabel";
            this.changeCaptchaLinkLabel.Size = new System.Drawing.Size(85, 13);
            this.changeCaptchaLinkLabel.TabIndex = 17;
            this.changeCaptchaLinkLabel.TabStop = true;
            this.changeCaptchaLinkLabel.Text = "Не видно капчу";
            this.changeCaptchaLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeCaptchaLinkLabel_LinkClicked);
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(148, 169);
            this.captchaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(140, 20);
            this.captchaTextBox.TabIndex = 16;
            // 
            // captchaPictureBox
            // 
            this.captchaPictureBox.Location = new System.Drawing.Point(148, 105);
            this.captchaPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.captchaPictureBox.Name = "captchaPictureBox";
            this.captchaPictureBox.Size = new System.Drawing.Size(139, 47);
            this.captchaPictureBox.TabIndex = 15;
            this.captchaPictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Captcha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 73);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.changeCaptchaLinkLabel);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.captchaPictureBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.confirmationPasswordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmationPasswordTextBox;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.LinkLabel changeCaptchaLinkLabel;
        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.PictureBox captchaPictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}