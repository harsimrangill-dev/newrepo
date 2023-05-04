using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    //this is testing class which tests methods manually 
    //by calling methods one by one
    sealed class test
    {
        static void Main(string[] args)
        {

            calculation cal = new calculation();

            display output = new display();

            //creating pack class objects
            //we do not need to specify methods as all methods are
            //in  the constructor
            //and pack class itself calls card class
            //for both models
            //--easy
            pack smallDeck = new pack(1);
            
            //-- hard
            pack largeDeck = new pack(2);

            //creating card objects
            //using random but valid values
            
            Random rmd = new Random();

            //using a while loop so that we can test test the functions
            //with many examples
            //it is infinite loop because we ccan end it whenever we
            //want in the debugging menu
            while (true)
            {
                card c1 = new card(rmd.Next(1, 14), rmd.Next(1, 5));

                card c2 = new card(rmd.Next(1, 14), rmd.Next(1, 5));

                card c3 = new card(rmd.Next(1, 14), rmd.Next(1, 5));

                //operators
                card o1 = new card(rmd.Next(1, 14), rmd.Next(1, 5));

                card o2 = new card(rmd.Next(1, 14), rmd.Next(1, 5));

                //calling calculation class methods
                //simple one
                cal.calculate(c1, o1, c2);

                //advance one
                cal.calculate(c1, o1, c2, o2, c3);

                //display class menthods

                //first one getting operator type

                output.getOperator(o1);
                output.getOperator(o2);

                //displaying the problem
                output.problem(c1, o1, c2);

                //overloaded 
                output.problem(c1, o1, c2, o2, c3);
            }
        }

    }

}

       
