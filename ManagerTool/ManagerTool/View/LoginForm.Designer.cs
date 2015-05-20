namespace ManagerTool
{
    partial class LoginForm
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
            this.TexBoxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.BotonLogin = new System.Windows.Forms.Button();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.textBoxLocalHost = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.Label();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TexBoxUser
            // 
            this.TexBoxUser.Location = new System.Drawing.Point(70, 114);
            this.TexBoxUser.Name = "TexBoxUser";
            this.TexBoxUser.Size = new System.Drawing.Size(100, 20);
            this.TexBoxUser.TabIndex = 1;
            this.TexBoxUser.TextChanged += new System.EventHandler(this.TexBoxUser_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(201, 114);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPassword.TabIndex = 3;
            // 
            // BotonLogin
            // 
            this.BotonLogin.Location = new System.Drawing.Point(86, 150);
            this.BotonLogin.Name = "BotonLogin";
            this.BotonLogin.Size = new System.Drawing.Size(75, 23);
            this.BotonLogin.TabIndex = 4;
            this.BotonLogin.Text = "Login";
            this.BotonLogin.UseVisualStyleBackColor = true;
            this.BotonLogin.Click += new System.EventHandler(this.BotonLogin_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(86, 179);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(75, 23);
            this.BotonCerrar.TabIndex = 5;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(328, 14);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(75, 71);
            this.buttonCreateUser.TabIndex = 6;
            this.buttonCreateUser.Text = "Create User";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            // 
            // textBoxLocalHost
            // 
            this.textBoxLocalHost.Location = new System.Drawing.Point(70, 42);
            this.textBoxLocalHost.Multiline = true;
            this.textBoxLocalHost.Name = "textBoxLocalHost";
            this.textBoxLocalHost.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocalHost.TabIndex = 7;
            this.textBoxLocalHost.Text = "127.0.0.1";
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(67, 24);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 8;
            this.Server.Text = "Server";
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(201, 42);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatabase.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DataBase";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDatabase);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.textBoxLocalHost);
            this.Controls.Add(this.buttonCreateUser);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.BotonLogin);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TexBoxUser);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TexBoxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button BotonLogin;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.TextBox textBoxLocalHost;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

