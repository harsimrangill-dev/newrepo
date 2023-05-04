using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    class display:IGetOperator
    {
        public void instruction(string name)
        {
            Console.WriteLine("* Hello {0}, This is a Math practice app.\n* You can select between two difficulties \n\t\t -- easy " +
                "\n\t\t -- hard.\n* You will be presented with a calculation problem, that you have to solve," +
                "\n* At the end of every problem " +
                "you will get a choice to exit the app.\n* At the end you will get to know how many of your answers were correct",
                 name);
            Console.WriteLine("\n* Every problem consists of following expresions: \n\t +  -- addition \n\t -  -- subtraction " +
                "\n\t *  -- Multiplication \n\t /  -- Divide \n\n\t\t Enjoy Your Learning.");
        }

        //getting he operator
        public string getOperator(card opt)
        {
            //temperorty variable
            string temp = "";
            switch (opt.suit)
            {
                case 1:
                    {
                        temp = "+";
                        break;
                    }
                case 2:
                    {
                        temp = "-";
                        break;
                    }
                case 3:
                    {
                        temp = "*";          //multiply
                        break;
                    }
                case 4:
                    {
                        temp = "/";          //divide
                        break;
                    }
            }
            return temp;
        }

        public void problem(card c1, card opt, card c2)
        {
            string temp = getOperator(opt);

            Console.WriteLine("{0}  {1}  {2}", c1.value, temp, c2.value);


        }

        public void problem(card c1, card opt1, card c2, card opt2, card c3)
        {
            string temp1 = getOperator(opt1);
            string temp2 = getOperator(opt2);

            Console.WriteLine("{0}  {1}  {2}  {3}  {4}", c1.value, temp1, c2.value, temp2, c3.value);
        }
    }
}
