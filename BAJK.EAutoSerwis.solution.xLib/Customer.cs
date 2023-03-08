using System;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class Customer
    {
        public string name;
        public string surname;
        //public int age;
        // numer dowodu osobistego 
        public string IdCardNumber;

        public Customer(string name, string surname, string idCardNumber)
        {
            this.name = name;
            this.surname = surname;
            this.IdCardNumber = idCardNumber;
        }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }  
        public string IdCardNumber { get => IdCardNumber; set => IdCardNumber = value; }    

    }
}