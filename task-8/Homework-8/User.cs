using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class User : BaseModel
    {
            int id;
            string firstNameCustomer;
            string lastNameCustomer;
            string surnameCustomer;
            string phoneNumber;
            string adressCustomer;
            public static int counter;

            public int Id
            {
                get { return id; }
            }
            public string FirstNameCustomer
            {
                get { return firstNameCustomer; }
                set { if (!string.IsNullOrEmpty(value)) firstNameCustomer = value; }
            }
            public string LastNameCustomer
            {
                get { return lastNameCustomer; }
                set { if (!string.IsNullOrEmpty(value)) lastNameCustomer = value; }
            }
            public string SurnameCustomer
            {
            get;
            set;
            }
            public string PhoneNumber
            {
                 get => phoneNumber;
                 set 
                 {
                    if (!string.IsNullOrEmpty(value) && PhoneHelper.IsPhoneValid(value)) { phoneNumber = value; }

                 }
            }

        public string AdressCustomer
            {
                get => adressCustomer;
                set { if (!string.IsNullOrEmpty(value)) adressCustomer = value; }
            }
        static User()
        {
            Random Rand = new Random();
            User.counter = Rand.Next();


        }

            public User(string firstNameCustomer, string lastNameCustomer, string surnameCustomer = "", string adressCustomer = "")
            {
                this.id = User.counter;
                User.counter++;
                this.firstNameCustomer = firstNameCustomer;
                this.lastNameCustomer = lastNameCustomer;
                SurnameCustomer = surnameCustomer;
                this.adressCustomer = adressCustomer;
            }
            public User(string firstNfmeCustomer, string lastNameCustomer)
            {
                this.firstNameCustomer = firstNfmeCustomer;
                this.lastNameCustomer = lastNameCustomer;
            }
            public override string ToString()
            {
                return $"{id} {firstNameCustomer} {lastNameCustomer} {surnameCustomer} {adressCustomer}";
            }
        
    }
}
