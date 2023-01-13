using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW4.LINQPart
{
    public static class LINQTrainingClass
    {
        public static void ShowMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowList(List<Contact> contactList)
        {
            foreach (var contact in contactList)
            {
                contact.ShowContactInfo();
            }
        }

        public static void LocalMain()
        {
            Contact contact1 = new Contact(
                "Bob",
                "Bobson",
                "+38023451214",
                "bobson@gmail.com",
                "Microsoft",
                "Green Street",
                45);
            Contact contact2 = new Contact(
                "Bill",
                "Billson",
                "+38012531214",
                "billson@gmail.com",
                "Apple",
                "Red Street",
                25);
            Contact contact3 = new Contact(
                "Jake",
                "Jakeson",
                "+38234532343",
                "jakeson@gmail.com",
                "Google",
                "White Street",
                60);
            Contact contact4 = new Contact(
                "Mary",
                "Maryson",
                "+381241236764",
                "maryson@gmail.com",
                "Starbucks",
                "Purple Street",
                18);
            Contact contact5 = new Contact(
                "Jane",
                "Janeson",
                "+3902342321",
                "janeson@gmail.com",
                "Meta",
                "Yellow Street",
                29);

            List<Contact> contactList = new List<Contact>()
            {
                contact1,
                contact2,
                contact3,
                contact4,
                contact5
            };
            List<Contact> experimentalList = new List<Contact>();

            ShowMessage("Contact list");
            ShowList(contactList);

            ShowMessage("\nSELECT name and surname");
            IEnumerable<string> info =
                contactList.Select(x => x.Name + " " + x.Surname);

            foreach (var item in info)
            {
                Console.WriteLine(item);
            }

            ShowMessage("\nWHERE contacts younger than 40");
            experimentalList =
                contactList.Where(x => x.Age <= 40).ToList();
            ShowList(experimentalList);

            ShowMessage("\nORDER BY age");
            experimentalList =
                contactList.OrderBy(x => x.Age).ToList();
            ShowList(experimentalList);

            ShowMessage("\nORDER BY DESCENDING age");
            experimentalList =
                contactList.OrderByDescending(x => x.Age).ToList();
            ShowList(experimentalList);

            ShowMessage("\nALL younger than 40?");
            bool answer = contactList.All(x => x.Age <= 40);
            Console.WriteLine(answer);

            ShowMessage("\nANY younger than 40?");
            answer = contactList.Any(x => x.Age <= 40);
            Console.WriteLine(answer);

            ShowMessage("\nCOUNT everyone");
            Console.WriteLine(contactList.Count);

            ShowMessage("\nTAKE 2 contacts");
            experimentalList = contactList.Take(2).ToList();
            ShowList(experimentalList);

            ShowMessage("\nSKIP 1 contact");
            experimentalList = contactList.Skip(1).ToList();
            ShowList(experimentalList);

            ShowMessage("\nCONTAINS contact1?");
            Console.WriteLine(contactList.Contains(contact1));

            List<Contact> contactsGroup =
                new List<Contact> { contact1, contact2 };
            ShowMessage("\nINTERSECT 2 collections");
            experimentalList =
                contactList.Intersect(contactsGroup).ToList();
            ShowList(experimentalList);

            ShowMessage("\nCONCAT 2 collections");
            experimentalList =
                contactList.Concat(contactsGroup).ToList();
            ShowList(experimentalList);

            ShowMessage("\nFIRSTORDEFAULT of contacts " +
                "with phone number ends with 1214");
            var chosenOne =
                contactList
                .Where(x => x.Phone.EndsWith("1214"))
                .FirstOrDefault();
            chosenOne.ShowContactInfo();
        }
    }
}
