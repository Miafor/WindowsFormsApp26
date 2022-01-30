using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WindowsFormsApp26
{
    public class FileManager
    {
        public string _filePath = @"C:\Users\mia__\OneDrive\Dokument\adressbok.txt";



        public void SavePerson(string name, string adress, string postcode, string city, string phone, string email) 
        {
            using(StreamWriter writer = new StreamWriter(_filePath, true)) 
            {
                
                {
                    writer.WriteLine(name +","+adress+","+ postcode+","+ city+","+ phone+"," + email);
                }
              
            }
        }
        public void DeletePerson(string name, string adress, string postcode, string city, string phone, string email)
        { 

            string[] value = File.ReadAllLines(_filePath);
            List<string> valuesList = value.ToList();
            
            valuesList.Remove(name+","+adress+","+postcode+","+city+","+phone+","+email); 
            
            
            File.WriteAllLines(_filePath, valuesList);
        }
        public List<string> Search(string condition)
        {
           
               
                string[] searchdata = File.ReadAllLines(_filePath);
                var search = from data in searchdata
                             where data.Contains(condition)
                             select data;
            return search.ToList();


            

        }
    }
}
