using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Profile
{
    [Serializable]
    public class User
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string phone { get; set; }
        public string e_mail { get; set; }
        public User()
        {
            name = "";
            surname = "";
            phone = "";
            e_mail = "";
        }

        public User(string name, string surname, string phone, string e_mail)
        {
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.e_mail = e_mail;
        }
        public override string ToString()
        {
            return $"Имя : {name}\t\tФамилия : {surname}\t\tНомер телефона : {phone}\t\tEmail ; {e_mail}";
        }
    }
}
