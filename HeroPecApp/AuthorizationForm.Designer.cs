
namespace HeroPecApp
{
    partial class AuthorizationForm
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
            this.authorizationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailLoginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.restoreLinkLabel = new System.Windows.Forms.LinkLabel();
            this.stayLoggedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // authorizationButton
            // 
            this.authorizationButton.Location = new System.Drawing.Point(162, 110);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(139, 36);
            this.authorizationButton.TabIndex = 0;
            this.authorizationButton.Text = "Войти";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин/Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.Location = new System.Drawing.Point(18, 25);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Size = new System.Drawing.Size(139, 20);
            this.emailLoginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(18, 64);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(139, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(18, 90);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(114, 17);
            this.showPasswordCheckBox.TabIndex = 5;
            this.showPasswordCheckBox.Text = "Показать пароль";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Location = new System.Drawing.Point(15, 143);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(72, 13);
            this.registerLinkLabel.TabIndex = 6;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Регистрация";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // restoreLinkLabel
            // 
            this.restoreLinkLabel.AutoSize = true;
            this.restoreLinkLabel.Location = new System.Drawing.Point(15, 130);
            this.restoreLinkLabel.Name = "restoreLinkLabel";
            this.restoreLinkLabel.Size = new System.Drawing.Size(117, 13);
            this.restoreLinkLabel.TabIndex = 7;
            this.restoreLinkLabel.TabStop = true;
            this.restoreLinkLabel.Text = "Восстановить пароль";
            this.restoreLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.restoreLinkLabel_LinkClicked);
            // 
            // stayLoggedCheckBox
            // 
            this.stayLoggedCheckBox.AutoSize = true;
            this.stayLoggedCheckBox.Location = new System.Drawing.Point(18, 110);
            this.stayLoggedCheckBox.Name = "stayLoggedCheckBox";
            this.stayLoggedCheckBox.Size = new System.Drawing.Size(111, 17);
            this.stayLoggedCheckBox.TabIndex = 8;
            this.stayLoggedCheckBox.Text = "Запомнить меня";
            this.stayLoggedCheckBox.UseVisualStyleBackColor = true;
            this.stayLoggedCheckBox.CheckedChanged += new System.EventHandler(this.stayLoggedCheckBox_CheckedChanged);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 166);
            this.Controls.Add(this.stayLoggedCheckBox);
            this.Controls.Add(this.restoreLinkLabel);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailLoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorizationButton);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailLoginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.LinkLabel restoreLinkLabel;
        private System.Windows.Forms.CheckBox stayLoggedCheckBox;
    }
}