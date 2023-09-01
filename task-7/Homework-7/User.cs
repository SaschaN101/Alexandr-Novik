using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class User
    {
        int id;
        string firstNameCustomer;
        string lastNameCustomer;
        string surnameCustomer;
        string adressCustomer;

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
            get => surnameCustomer;
            set => surnameCustomer = value;
        }
        public string AdressCustomer
        {
            get => adressCustomer;
            set { if (!string.IsNullOrEmpty(value)) adressCustomer = value; }
        }
        public User(int id, string firstNameCustomer, string lastNameCustomer, string surnameCustomer, string adressCustomer)
        {
            this.id = id;
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
