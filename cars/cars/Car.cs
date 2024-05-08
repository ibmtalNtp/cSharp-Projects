using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace cars
{
    class Car 
    {
        public String name;
        public String brand;
        public double price;
        public String color;
        public int model;
        public Car() {
            this.name = "";
            this.brand = "";
            this.price = 0;
            this.color = "";
            this.model = 0;
        }
        public Car(String name,String brand,double price,String color,int model) {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.color = color;
            this.model = model;
        }
    }
}
