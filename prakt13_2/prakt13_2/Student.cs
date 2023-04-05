using System.Collections;
using System.Collections.Generic;
namespace prakt13_2
{
    class Student
    {
        private string name;
        private string fam;
        private string Nomer;
        public Student(string name, string fam, string recordBookNumber)
        {
            this.name = name;
            this.fam = fam;
            this.Nomer = recordBookNumber;
        }
        
        public string getName()
        {
            return this.name;
        }
        public string getFam()
        {
            return this.fam;
        }
        public string getNomer()
        {
            return this.Nomer;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSurname(string surname)
        {
            this.fam = surname;
        }
        public void setNomer(string Nomer)
        {
            this.Nomer = Nomer;
        }
    }
}
