using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW4.LINQPart
{
    public class Contact
    {
        public Contact(
            string name,
            string surname,
            string phone,
            string email,
            string companyName,
            string address,
            int age)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            CompanyName = companyName;
            Address = address;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void ShowContactInfo()
        {
            Console.WriteLine(
                Name + " " +
                Surname + " " +
                Email + " " +
                Phone + " " +
                Age + " " +
                CompanyName + " " +
                Address);
        }
    }
}
