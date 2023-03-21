using System;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class Customer
    {
        public string name;
        public string surname;
        //public int age;
        // numer dowodu osobistego 
        public string idCardNumber;
        public string email;
        public double owedTotal;
        public string[] ownedCars;
        public string lastVisit;

        public Customer(string name, string surname, string idCardNumber, string email, double owedtotal, string[] ownedcars, string lastvisit)
        {
            this.name = name;
            this.surname = surname;
            this.idCardNumber = idCardNumber;
            this.email = email;
            this.owedTotal = owedtotal;
            this.ownedCars = ownedcars;
            this.lastVisit = lastvisit; 
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }  
        public string IdCardNumber { get => IdCardNumber; set => IdCardNumber = value; }    
        public string Email { get => email; set => email = value; }
        public double OwedTotal { get => owedTotal; set => owedTotal = value; }
        public string[] OwnedCars { get => ownedCars; set => ownedCars = value; }
        public string LastVisit { get => lastVisit; set => lastVisit = value; }
    }
}