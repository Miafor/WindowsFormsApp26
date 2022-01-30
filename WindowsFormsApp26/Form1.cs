using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        private Person  _personClass; 

        public Form1()
        {
            InitializeComponent();
            
            
        }
        //public void Add() 
        //{
        //    string name = textBoxName.Text;
        //    string adress = textBoxAddress.Text;
        //    string postCode = textBoxPostCode.Text;
        //    string city = textBoxCity.Text;
        //    string phone = textBoxPhone.Text;
        //    string email = textBoxEmail.Text;

        //    using (StreamWriter writer= new StreamWriter(filePath, true))
        //    {
        //        writer.WriteLine(name + "," + adress + "," + postCode + "," + city +"," + phone+ "," + email);
        //    }

        //}

        private void AddToAdressBook(object sender, EventArgs e)
        {
            _personClass = new Person(textBoxName.Text, textBoxAddress.Text, textBoxPostCode.Text, textBoxCity.Text, textBoxPhone.Text, textBoxEmail.Text);
           
            _personClass.AddPerson(textBoxName.Text, textBoxAddress.Text, textBoxPostCode.Text, textBoxCity.Text, textBoxPhone.Text, textBoxEmail.Text);
           
            Clear();

        }
        //private void Delete() 
        //{
        //    string name = textBoxName.Text;
        //    string adress = textBoxAddress.Text;
        //    string postCode = textBoxPostCode.Text;
        //    string city = textBoxCity.Text;
        //    string phone = textBoxPhone.Text;
        //    string email = textBoxEmail.Text;

        //    string[] values = File.ReadAllLines(filePath);
        //    List<string> valuesList = values.ToList();
        //    valuesList.Remove(name + "," + adress + "," + postCode + "," + city + "," + phone + "," + email);
        //    File.WriteAllLines(filePath, valuesList);
           
           
        //}
        

        private void DeleteItem(object sender, EventArgs e)
        {
            Person p = new Person();
            
            p.DeleteAPerson(textBoxName.Text, textBoxAddress.Text, textBoxPostCode.Text, textBoxCity.Text,
                                                            textBoxPhone.Text, textBoxEmail.Text);
            Clear();
            listBoxResult.Items.Clear();
        }
        

        private void SearchList(object sender, EventArgs e)
        {
            FileManager manager = new FileManager();
            List<string> results= manager.Search(textBoxSearch.Text);
            foreach (var item in results)
            {
                listBoxResult.Items.Add(item);
            }

        }

        private void Select(object sender, EventArgs e)
        {
            
            string values = listBoxResult.GetItemText(listBoxResult.SelectedItem);
            List<string> ValuesList = new List<string>();
            
            
                ValuesList = values.Split(',').ToList();
                textBoxName.Text= ValuesList[0];
                textBoxAddress.Text = ValuesList[1];
                textBoxPostCode.Text = ValuesList[2];
                textBoxCity.Text = ValuesList[3];
                textBoxPhone.Text = ValuesList[4];
                textBoxEmail.Text = ValuesList[5];
            
            
        }

        private void Show(object sender, EventArgs e)
        {
            Select();
        }
        
        private void Change(object sender, EventArgs e)
        {
            Person p = new Person();
            
            p.Update(textBoxName.Text, textBoxAddress.Text, textBoxPostCode.Text, textBoxCity.Text, textBoxPhone.Text, textBoxEmail.Text);

           
            MessageBox.Show("Uppgifterna har uppdaterats");
            Clear();

        }
        private void Clear() 
        {
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            textBoxPostCode.Text = "";
            textBoxCity.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
        }
    }
    
}
