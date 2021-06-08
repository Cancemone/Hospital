
namespace Hospital
{
    partial class Registration
    {
        private const string V = "Registration";

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
            System.Windows.Forms.Label Name;
            this.Surname = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonRegistrate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            Name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Name.Location = new System.Drawing.Point(351, 87);
            Name.Margin = new System.Windows.Forms.Padding(0);
            Name.Name = "Name";
            Name.Size = new System.Drawing.Size(62, 25);
            Name.TabIndex = 1;
            Name.Text = "Name";
            Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Surname.Location = new System.Drawing.Point(351, 137);
            this.Surname.Margin = new System.Windows.Forms.Padding(0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(87, 25);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Patronymic.Location = new System.Drawing.Point(351, 189);
            this.Patronymic.Margin = new System.Windows.Forms.Padding(0);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(109, 25);
            this.Patronymic.TabIndex = 3;
            this.Patronymic.Text = "Patronymic";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Department.Location = new System.Drawing.Point(351, 245);
            this.Department.Margin = new System.Windows.Forms.Padding(0);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(115, 25);
            this.Department.TabIndex = 4;
            this.Department.Text = "Department";
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(351, 301);
            this.Login.Margin = new System.Windows.Forms.Padding(0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(59, 25);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.Control;
            this.Password.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(351, 357);
            this.Password.Margin = new System.Windows.Forms.Padding(0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(92, 25);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(351, 117);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(154, 23);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(351, 166);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(154, 23);
            this.textBoxSurname.TabIndex = 8;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(351, 218);
            this.textBoxPatronymic.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(154, 23);
            this.textBoxPatronymic.TabIndex = 9;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(351, 274);
            this.textBoxDepartment.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(154, 23);
            this.textBoxDepartment.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(351, 386);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(154, 23);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(351, 330);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(154, 23);
            this.textBoxLogin.TabIndex = 12;
            // 
            // buttonRegistrate
            // 
            this.buttonRegistrate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRegistrate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistrate.ForeColor = System.Drawing.Color.SpringGreen;
            this.buttonRegistrate.Location = new System.Drawing.Point(367, 417);
            this.buttonRegistrate.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.buttonRegistrate.Name = "buttonRegistrate";
            this.buttonRegistrate.Size = new System.Drawing.Size(119, 38);
            this.buttonRegistrate.TabIndex = 13;
            this.buttonRegistrate.Text = "Registrate";
            this.buttonRegistrate.UseVisualStyleBackColor = false;
            this.buttonRegistrate.Click += new System.EventHandler(this.buttonRegistrate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registration";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 43);
            this.panel1.TabIndex = 15;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(725, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 28);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log in";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistrate);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.Surname);
            this.Controls.Add(Name);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonRegistrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}