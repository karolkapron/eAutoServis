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
        public string email;
        public double owedTotal;
        public string[] ownedCars;
        public string lastVisit;

        public Customer(string name, string surname, string idCardNumber, string email, double owedtotal, string[] ownedcars, string lastvisit)
        {
            this.name = name;
            this.surname = surname;
            this.IdCardNumber = idCardNumber;
            this.email = email;
            this.owedTotal = owedtotal;
            this.ownedCars = ownedcars;
            this.lastVisit = lastvisit; 
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }  
        public string IdCardNumber { get => IdCardNumber; set => IdCardNumber = value; }    
        public string Email { get => email; set => email = value; }
        public double owedTotal { get => owedTotal; set => owedTotal = value; }
        public string ownedCars { get => ownedCars; set => ownedCars = value; }
        public string lastVisit { get => lastVisit; set => lastVisit = value; }
    }
}