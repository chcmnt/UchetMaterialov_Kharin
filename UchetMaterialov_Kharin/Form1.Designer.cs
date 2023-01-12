namespace UchetMaterialov_Kharin
{
    partial class Form1
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
            this.Title_Auth = new System.Windows.Forms.Label();
            this.Txt_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_Auth
            // 
            this.Title_Auth.AutoSize = true;
            this.Title_Auth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_Auth.Location = new System.Drawing.Point(44, 19);
            this.Title_Auth.Name = "Title_Auth";
            this.Title_Auth.Size = new System.Drawing.Size(181, 32);
            this.Title_Auth.TabIndex = 0;
            this.Title_Auth.Text = "Вход в систему";
            this.Title_Auth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_login
            // 
            this.Txt_login.Location = new System.Drawing.Point(81, 92);
            this.Txt_login.Name = "Txt_login";
            this.Txt_login.Size = new System.Drawing.Size(100, 23);
            this.Txt_login.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // Txt_password
            // 
            this.Txt_password.Location = new System.Drawing.Point(81, 151);
            this.Txt_password.Name = "Txt_password";
            this.Txt_password.Size = new System.Drawing.Size(100, 23);
            this.Txt_password.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login_btn.Location = new System.Drawing.Point(81, 205);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(100, 35);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "Вход";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit_btn.Location = new System.Drawing.Point(81, 257);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(100, 35);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "Выход";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 335);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_password);
            this.Controls.Add(this.Txt_login);
            this.Controls.Add(this.Title_Auth);
            this.Name = "Form1";
            this.Text = "Учет материалов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title_Auth;
        private TextBox Txt_login;
        private Label label1;
        private TextBox Txt_password;
        private Label label2;
        private Button Login_btn;
        private Button Exit_btn;
    }
}