using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class Mechanic
    {
        public string name;
        public string surname;
        public Guid id;
        public string specialisation;
        

        public Mechanic(Guid _id, string _name, string _surname, string _specialisation)
        {
            this.id = _id;
            this.name = _name;
            this.surname = _surname;
            this.specialisation = _specialisation;
        }
        public Guid Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Specialisation { get => specialisation; set => specialisation = value; }



    }
}
