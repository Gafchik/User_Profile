
using System;
using System.IO;

namespace User_Profile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            File.Delete("User.xml");
            using (FileStream fs = new FileStream("User.xml", FileMode.Create))
            {
                
                formatter.Serialize(fs, users);

            }
            if (disposing && (components != null))
            {
                
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.new_user = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butt_add = new System.Windows.Forms.Button();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.text_phon = new System.Windows.Forms.TextBox();
            this.text_surname = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.Label();
            this.user_surname = new System.Windows.Forms.Label();
            this.user_phone = new System.Windows.Forms.Label();
            this.user_Email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_chenge = new System.Windows.Forms.CheckBox();
            this.user_name2 = new System.Windows.Forms.Label();
            this.user_surname2 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.user_phone2 = new System.Windows.Forms.Label();
            this.current_name = new System.Windows.Forms.TextBox();
            this.user_Email2 = new System.Windows.Forms.Label();
            this.current_surname = new System.Windows.Forms.TextBox();
            this.current_phone = new System.Windows.Forms.TextBox();
            this.current_Email = new System.Windows.Forms.TextBox();
            this.info_user = new System.Windows.Forms.Label();
            this.list_users = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // new_user
            // 
            this.new_user.AutoSize = true;
            this.new_user.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.new_user.Location = new System.Drawing.Point(123, 9);
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(115, 13);
            this.new_user.TabIndex = 0;
            this.new_user.Text = "Новый пользователь";
            this.new_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.butt_add);
            this.panel1.Controls.Add(this.text_Email);
            this.panel1.Controls.Add(this.text_phon);
            this.panel1.Controls.Add(this.text_surname);
            this.panel1.Controls.Add(this.text_name);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.user_surname);
            this.panel1.Controls.Add(this.user_phone);
            this.panel1.Controls.Add(this.user_Email);
            this.panel1.Location = new System.Drawing.Point(23, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 241);
            this.panel1.TabIndex = 1;
            // 
            // butt_add
            // 
            this.butt_add.Location = new System.Drawing.Point(101, 193);
            this.butt_add.Name = "butt_add";
            this.butt_add.Size = new System.Drawing.Size(75, 23);
            this.butt_add.TabIndex = 9;
            this.butt_add.Text = "Добавить";
            this.butt_add.UseVisualStyleBackColor = true;
            // 
            // text_Email
            // 
            this.text_Email.Location = new System.Drawing.Point(147, 139);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(100, 20);
            this.text_Email.TabIndex = 8;
            // 
            // text_phon
            // 
            this.text_phon.Location = new System.Drawing.Point(147, 102);
            this.text_phon.Name = "text_phon";
            this.text_phon.Size = new System.Drawing.Size(100, 20);
            this.text_phon.TabIndex = 7;
            // 
            // text_surname
            // 
            this.text_surname.Location = new System.Drawing.Point(147, 62);
            this.text_surname.Name = "text_surname";
            this.text_surname.Size = new System.Drawing.Size(100, 20);
            this.text_surname.TabIndex = 6;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(147, 21);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 5;
            // 
            // user_name
            // 
            this.user_name.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_name.Location = new System.Drawing.Point(18, 19);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(100, 23);
            this.user_name.TabIndex = 4;
            this.user_name.Text = "Имя";
            this.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_surname
            // 
            this.user_surname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_surname.Location = new System.Drawing.Point(18, 59);
            this.user_surname.Name = "user_surname";
            this.user_surname.Size = new System.Drawing.Size(100, 23);
            this.user_surname.TabIndex = 3;
            this.user_surname.Text = "Фамилия";
            this.user_surname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_phone
            // 
            this.user_phone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_phone.Location = new System.Drawing.Point(18, 100);
            this.user_phone.Name = "user_phone";
            this.user_phone.Size = new System.Drawing.Size(100, 23);
            this.user_phone.TabIndex = 2;
            this.user_phone.Text = "Номер телефона";
            this.user_phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_Email
            // 
            this.user_Email.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_Email.Location = new System.Drawing.Point(29, 141);
            this.user_Email.Name = "user_Email";
            this.user_Email.Size = new System.Drawing.Size(100, 23);
            this.user_Email.TabIndex = 1;
            this.user_Email.Text = "Email";
            this.user_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rb_chenge);
            this.panel2.Controls.Add(this.user_name2);
            this.panel2.Controls.Add(this.user_surname2);
            this.panel2.Controls.Add(this.change);
            this.panel2.Controls.Add(this.user_phone2);
            this.panel2.Controls.Add(this.current_name);
            this.panel2.Controls.Add(this.user_Email2);
            this.panel2.Controls.Add(this.current_surname);
            this.panel2.Controls.Add(this.current_phone);
            this.panel2.Controls.Add(this.current_Email);
            this.panel2.Location = new System.Drawing.Point(363, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 241);
            this.panel2.TabIndex = 0;
            // 
            // rb_chenge
            // 
            this.rb_chenge.AutoSize = true;
            this.rb_chenge.Location = new System.Drawing.Point(27, 198);
            this.rb_chenge.Name = "rb_chenge";
            this.rb_chenge.Size = new System.Drawing.Size(83, 17);
            this.rb_chenge.TabIndex = 15;
            this.rb_chenge.Text = "Изменить?";
            this.rb_chenge.UseVisualStyleBackColor = true;
            // 
            // user_name2
            // 
            this.user_name2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_name2.Location = new System.Drawing.Point(24, 21);
            this.user_name2.Name = "user_name2";
            this.user_name2.Size = new System.Drawing.Size(100, 23);
            this.user_name2.TabIndex = 14;
            this.user_name2.Text = "Имя";
            this.user_name2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_surname2
            // 
            this.user_surname2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_surname2.Location = new System.Drawing.Point(24, 62);
            this.user_surname2.Name = "user_surname2";
            this.user_surname2.Size = new System.Drawing.Size(100, 23);
            this.user_surname2.TabIndex = 13;
            this.user_surname2.Text = "Фамилия";
            this.user_surname2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Location = new System.Drawing.Point(187, 193);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 9;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            // 
            // user_phone2
            // 
            this.user_phone2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_phone2.Location = new System.Drawing.Point(24, 102);
            this.user_phone2.Name = "user_phone2";
            this.user_phone2.Size = new System.Drawing.Size(100, 23);
            this.user_phone2.TabIndex = 12;
            this.user_phone2.Text = "Номер телефона";
            this.user_phone2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current_name
            // 
            this.current_name.Enabled = false;
            this.current_name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.current_name.Location = new System.Drawing.Point(162, 21);
            this.current_name.Name = "current_name";
            this.current_name.Size = new System.Drawing.Size(100, 20);
            this.current_name.TabIndex = 4;
            // 
            // user_Email2
            // 
            this.user_Email2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.user_Email2.Location = new System.Drawing.Point(24, 141);
            this.user_Email2.Name = "user_Email2";
            this.user_Email2.Size = new System.Drawing.Size(100, 23);
            this.user_Email2.TabIndex = 11;
            this.user_Email2.Text = "Email";
            this.user_Email2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current_surname
            // 
            this.current_surname.Enabled = false;
            this.current_surname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.current_surname.Location = new System.Drawing.Point(162, 61);
            this.current_surname.Name = "current_surname";
            this.current_surname.Size = new System.Drawing.Size(100, 20);
            this.current_surname.TabIndex = 3;
            // 
            // current_phone
            // 
            this.current_phone.Enabled = false;
            this.current_phone.ForeColor = System.Drawing.SystemColors.Desktop;
            this.current_phone.Location = new System.Drawing.Point(162, 102);
            this.current_phone.Name = "current_phone";
            this.current_phone.Size = new System.Drawing.Size(100, 20);
            this.current_phone.TabIndex = 2;
            // 
            // current_Email
            // 
            this.current_Email.Enabled = false;
            this.current_Email.ForeColor = System.Drawing.SystemColors.Desktop;
            this.current_Email.Location = new System.Drawing.Point(162, 141);
            this.current_Email.Name = "current_Email";
            this.current_Email.Size = new System.Drawing.Size(100, 20);
            this.current_Email.TabIndex = 1;
            // 
            // info_user
            // 
            this.info_user.AutoSize = true;
            this.info_user.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.info_user.Location = new System.Drawing.Point(401, 9);
            this.info_user.Name = "info_user";
            this.info_user.Size = new System.Drawing.Size(211, 13);
            this.info_user.TabIndex = 10;
            this.info_user.Text = "Информация о выбраном пользователе";
            this.info_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_users
            // 
            this.list_users.FormattingEnabled = true;
            this.list_users.Location = new System.Drawing.Point(23, 307);
            this.list_users.Name = "list_users";
            this.list_users.Size = new System.Drawing.Size(625, 173);
            this.list_users.TabIndex = 11;
            // 
            // delete
            // 
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(305, 486);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 521);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.list_users);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.info_user);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.new_user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label new_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butt_add;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.TextBox text_phon;
        private System.Windows.Forms.TextBox text_surname;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label user_surname;
        private System.Windows.Forms.Label user_phone;
        private System.Windows.Forms.Label user_Email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox current_name;
        private System.Windows.Forms.TextBox current_surname;
        private System.Windows.Forms.TextBox current_phone;
        private System.Windows.Forms.TextBox current_Email;
        private System.Windows.Forms.Label info_user;
        private System.Windows.Forms.Label user_name2;
        private System.Windows.Forms.Label user_surname2;
        private System.Windows.Forms.Label user_phone2;
        private System.Windows.Forms.Label user_Email2;
        private System.Windows.Forms.CheckBox rb_chenge;
        private System.Windows.Forms.ListBox list_users;
        private System.Windows.Forms.Button delete;
    }
}

