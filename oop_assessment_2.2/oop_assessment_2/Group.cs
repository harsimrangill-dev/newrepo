using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    abstract class Group
    {
        //list that contains the numbers for card value
        protected static List<int> numbers = new List<int>();

        //static field for containig the value to the suits/ operators
        protected static List<int> operators = new List<int>();

        


        //method for populizing the groups 
        protected static void insert()
        {
            for (int i = 1; i < 14; i++)
            {
                numbers.Add(i);
                if(i < 5)
                {
                    operators.Add(i);
                }
            }
        }
        //method for displaying the groups it contains 
        public override string ToString()
        {
            string temp1 = " ";
            foreach(int i in numbers)
            {
                temp1 += i + " ";
            }
            string temp2 = " ";
            foreach(int i in operators)
            {
                temp2 += i + " ";
            }
            return "numbers: \n" + temp1 + "\noperators: \n" + temp2;
        }
    }
}
