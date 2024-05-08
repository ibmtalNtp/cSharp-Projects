using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portfolio
{
    class Person
    {
        public String name;
        public String surname;
        public String photo;
        public int birthYear;
        public double length;
        public double weight;
        public Person() {
            this.name = "";
            this.surname = "";
            this.photo = "";
            this.birthYear = 0;
            this.length = 0;
            this.weight = 0;
        }
    }
}
