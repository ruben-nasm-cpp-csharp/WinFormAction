
namespace WinFormAction
{
    partial class auth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_auth_password = new System.Windows.Forms.Label();
            this.label_auth_login = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 23);
            this.textBox2.TabIndex = 2;
            // 
            // label_auth_password
            // 
            this.label_auth_password.AutoSize = true;
            this.label_auth_password.Location = new System.Drawing.Point(6, 52);
            this.label_auth_password.Name = "label_auth_password";
            this.label_auth_password.Size = new System.Drawing.Size(49, 15);
            this.label_auth_password.TabIndex = 3;
            this.label_auth_password.Text = "Пароль";
            // 
            // label_auth_login
            // 
            this.label_auth_login.AutoSize = true;
            this.label_auth_login.Location = new System.Drawing.Point(14, 12);
            this.label_auth_login.Name = "label_auth_login";
            this.label_auth_login.Size = new System.Drawing.Size(41, 15);
            this.label_auth_login.TabIndex = 4;
            this.label_auth_login.Text = "Логин";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 112);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_auth_login);
            this.Controls.Add(this.label_auth_password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_auth_password;
        private System.Windows.Forms.Label label_auth_login;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

