using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listboxObject
{
    class GraphicCard
    {
        public String name;
        public double ram;
        public double speed;
        public bool shared;
        public double price;
        //new GraphicCard()
        public GraphicCard() {
            this.name = "";
            this.ram = 0;
            this.speed = 0;
            this.shared = false;
            this.price = 0;
        }
        //new GraphicCard("ASUS GEFORCE",2048,1023,true,36399.50);
        public GraphicCard(String name,double ram
                    ,double speed,bool shared,double price)
        {
            this.name = name;
            this.ram = ram;
            this.speed = speed;
            this.shared = shared;
            this.price = price;
        }

    }
}
