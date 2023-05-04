using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    class calculation: Icalculation
    {
        public card calculate(card c1, card opt, card c2)
        {

            //operator values are in increasing order for BODMAS
            //as it is easy to compare just based on the numeric values
            
            switch (opt.suit)
            {
                case 1:
                    {
                        return (c1 + c2);          //addidition 
                    }
                case 2:
                    {
                        return (c1 - c2);          //subtraction
                    }
                case 3:
                    {
                        return (c1 * c2);          //multiplication
                    }
                case 4:
                    {
                        return (c1 / c2);          //divide
                    }
                //default value in case of error
                default:
                    return new card(0,0);
            }
            

        }

        //overload for 5 cards
        public card calculate(card c1, card opt1, card c2,card opt2, card c3)
        {
            //creating a temporay card to hold values
            card temp;
            //if first operator has prority according to BODMAS
            if (opt1.suit >= opt2.suit)
            {
                temp = calculate(c1, opt1 ,c2);
                //calculating the next value
                return calculate(temp, opt2, c3);
            }
            //if the second has the prority
            else
            {
                temp = calculate(c2, opt2, c3);
                //calculating the next value
                return calculate(c1, opt1, temp);
            }
        }
      

    }
}
