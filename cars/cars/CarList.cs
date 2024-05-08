using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace cars
{
    class CarList : ListBox
    {
        public List<Car> cars;
        public CarList(){
            cars = new List<Car>();
        }
        public void add(Car car) {
            this.cars.Add(car);
            this.Items.Add(car.name);
        }
    }
}
