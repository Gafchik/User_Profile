using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace User_Profile
{
    public partial class Form1 : Form
    {
        List<User> users;
        XmlSerializer formatter;
        public Form1()
        {
            formatter = new XmlSerializer(typeof(List<User>));
            users = new List<User>();
            using (FileStream fs = new FileStream("User.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    users.AddRange((formatter.Deserialize(fs) as List<User>));

                    Console.WriteLine("Объект десериализован");
                }
                catch (Exception)
                {

                }    
            }
            InitializeComponent();
            list_users.Items.Clear();
            rb_chenge.CheckedChanged += Rb_chenge_CheckedChanged;
            butt_add.Click += Butt_add_Click;
            list_users.SelectedValueChanged += List_users_SelectedValueChanged;
            change.Click += Change_Click;
            delete.Click += Delete_Click;

            users.ForEach(i => list_users.Items.Add(i.ToString()));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int q = list_users.SelectedIndex;
            users.Remove(users.Find(i => i.ToString() == list_users.SelectedItem.ToString()));
            list_users.SelectedIndex = 0;
            list_users.Items.RemoveAt(q);
        }
    

        private void Change_Click(object sender, EventArgs e)
        {

            User temp_u = new User(current_name.Text, current_surname.Text, current_phone.Text, current_Email.Text);

            users[users.FindIndex(i => i.ToString() == list_users.SelectedItem.ToString())] = temp_u;
            list_users.Items.Clear();
            users.ForEach(i => list_users.Items.Add(i.ToString()));



        }

        private void List_users_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                delete.Enabled = true;
                User temp = users.Find(i => i.ToString() == (sender as ListBox).SelectedItem.ToString());
                current_Email.Text = temp.e_mail;
                current_name.Text = temp.name;
                current_surname.Text = temp.surname;
                current_phone.Text = temp.phone;
            }
            catch (Exception)
            {
                current_Email.Text = "";
                current_name.Text = "";
                current_surname.Text ="";
                current_phone.Text = "";
            }
        }

        private void Butt_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(text_Email.Text==""||
                    text_name.Text==""||
                    text_phon.Text==""||
                    text_surname.Text=="")
                { throw new NullReferenceException(); }
                else
                {
                    User temp_u = new User(text_name.Text, text_surname.Text, text_phon.Text, text_Email.Text);
                    list_users.Items.Add(temp_u.ToString());
                    users.Add(temp_u);
                }
           
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Rb_chenge_CheckedChanged(object sender, EventArgs e)
        {
           if((sender as CheckBox).Checked)
            {
                change.Enabled = true;
                current_Email.Enabled = true;
                current_name.Enabled = true;
                current_phone.Enabled = true;
                current_surname.Enabled = true;
            }
            else
            {
                change.Enabled = false;
                current_Email.Enabled = false;
                current_name.Enabled = false;
                current_phone.Enabled = false;
                current_surname.Enabled = false;
            }
        }
    }
}
