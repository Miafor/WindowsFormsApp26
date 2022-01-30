using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp26
{
    public class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


        public Person()
        {

        }

        public Person(string name, string adress, string postCode, string city, string phone, string email)
        {
            Name = name;
            Adress = adress;
            PostCode = postCode;
            City = city;
            Phone = phone;
            Email = email;
        }

        public void AddPerson(string name, string adress, string postCode, string city, string phone, string email) 
        {
            FileManager manager = new FileManager();
           
            manager.SavePerson(name, adress, postCode, city,phone, email);
        }
        public void Update(string name, string adress, string postCode, string city, string phone, string email)
        {
            FileManager manager = new FileManager();
           
            List<string> person= CreatePersonList(name, adress, postCode, city, phone, email);
            manager.DeletePerson(name, adress, postCode, city, phone, email);
            manager.SavePerson(name,adress, postCode,city, phone, email);
        }
        public void DeleteAPerson(string name, string adress, string postcode, string city, string phone, string email)

        {
            FileManager manager = new FileManager();
            manager.DeletePerson(name, adress, postcode,city, phone, email);

        }
        public List<string> CreatePersonList(string name, string adress, string postcode, string city, string phone, string email) 
        {
            List<string> personList = new List<string>(){ name+","+ adress+","+postcode+","+city+","+phone+","+email };
          
            //personList.Add(name);
            //personList.Add(adress);
            //personList.Add(postcode);
            //personList.Add(city);
            //personList.Add(phone);
            //personList.Add(email);
            return personList;
        }
    }
}