using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    class Data
    {
        //It is class which is for containing any type of data

        //field to add the value of the entered data
        //protected so that only way to enter is through methods or inherited classes

        protected internal double value { get; set; }

        //constructor
        public Data(double value)
        {
            this.value = value;
        }

        //field to get data
        public virtual double getData()
        {
            return value;
        }

        //firld to enter data
        public virtual void addData(double value)
        {
            this.value = value;
        }
        //overriding the string mehod
        public override string ToString()
        {
            return "Value is " + value;
        }
    }
}
