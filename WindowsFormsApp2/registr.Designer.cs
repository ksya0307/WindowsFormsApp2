namespace WindowsFormsApp2
{
    partial class registr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registr));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.dad_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registracia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.birth);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.dad_name);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.last_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пользователь";
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(160, 318);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(215, 30);
            this.birth.TabIndex = 22;
            // 
            // phone
            // 
            this.phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.phone.Location = new System.Drawing.Point(160, 279);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(215, 30);
            this.phone.TabIndex = 21;
            this.phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // email
            // 
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.email.Location = new System.Drawing.Point(160, 240);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(215, 30);
            this.email.TabIndex = 16;
            // 
            // pass
            // 
            this.pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.pass.Location = new System.Drawing.Point(160, 201);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(215, 30);
            this.pass.TabIndex = 15;
            // 
            // login
            // 
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.login.Location = new System.Drawing.Point(160, 162);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(215, 30);
            this.login.TabIndex = 14;
            // 
            // dad_name
            // 
            this.dad_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.dad_name.Location = new System.Drawing.Point(160, 123);
            this.dad_name.Name = "dad_name";
            this.dad_name.Size = new System.Drawing.Size(215, 30);
            this.dad_name.TabIndex = 13;
            this.dad_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dad_name_KeyPress);
            // 
            // name
            // 
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.name.Location = new System.Drawing.Point(160, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(215, 30);
            this.name.TabIndex = 12;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // last_name
            // 
            this.last_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.last_name.Location = new System.Drawing.Point(160, 45);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(215, 30);
            this.last_name.TabIndex = 11;
            this.last_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.last_name_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(8, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label8.Location = new System.Drawing.Point(7, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(7, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Почта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(7, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // registracia
            // 
            this.registracia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(212)))), ((int)(((byte)(119)))));
            this.registracia.FlatAppearance.BorderSize = 0;
            this.registracia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registracia.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registracia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(66)))), ((int)(((byte)(74)))));
            this.registracia.Location = new System.Drawing.Point(118, 407);
            this.registracia.Name = "registracia";
            this.registracia.Size = new System.Drawing.Size(193, 34);
            this.registracia.TabIndex = 23;
            this.registracia.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.registracia.UseVisualStyleBackColor = false;
            this.registracia.Click += new System.EventHandler(this.registracia_Click);
            // 
            // registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 473);
            this.Controls.Add(this.registracia);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание личного кабинета";
            this.Load += new System.EventHandler(this.registr_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox dad_name;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.Button registracia;
    }
}