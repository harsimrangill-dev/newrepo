using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oop_assessment_2
{
    class Tutorial
    {
        static void junior(string[] args)
        {
            //Welcome message
            Console.WriteLine("\t\t\t Welcome To The Maths Tutor");
            //defining name in this scope
            string name;

            //intiating the classes
            //display object
            display output = new display();

            //calculation object
            calculation solve = new calculation();

            while (true)
            {
                try
                {
                    //name of the user
                    Console.WriteLine("What is you name? ");
                    name = Console.ReadLine();
                    //if the name is empty
                    if (name == null || name == "")
                    {
                        throw new ArgumentNullException();
                    }
                    //if the name is valid
                    else
                    {
                        break;
                    }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter a valid name.");
                    continue;
                }
            }
            //displaying instruction
            output.instruction(name);

            //difficulty variable
            int difficulty = 0;
            //next loop
            while (true)
            {
                try
                {
                    Console.WriteLine("choose Difficulty: \n\t\t 1.) easy \t 2.) hard");
                    string temp = Console.ReadLine();
                    //checking validity
                    if ( temp == "1" || temp == "2")
                    {
                        difficulty = Convert.ToInt32(temp);
                        break;
                    }
                    else
                    {
                        throw new InvalidArgumentException("Please Enter a valid input");
                    }
                }
                catch(InvalidArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }                
            }
            //main while loop for asking questions
            //field for keeping track of right and wrong answers
            int right = 0, wrong = 0;

            while (true)
            {
                //creating a pack 
                //it will automaticlly select difficulty for us
                pack Equation = new pack(difficulty);
                
                //creating fields for conating the results
                card result;

                if (difficulty == 1)
                {
                    //getting results
                    result = solve.calculate(Equation.values[0], Equation.values[1], Equation.values[2]);
                    //displaying the problem
                    output.problem(Equation.values[0], Equation.values[1], Equation.values[2]);
                }

                else
                {
                    //getting results
                    result = solve.calculate(Equation.values[0], Equation.values[1], Equation.values[2],
                        Equation.values[3],Equation.values[4]);
                    //displaying the problem
                    output.problem(Equation.values[0], Equation.values[1], Equation.values[2],
                        Equation.values[3], Equation.values[4]);
                }

                //asking for answer
                double answer;
                //while loop for checkin the answer
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter your answer to the problem.. ");
                        //temporary field for holding the value before casting
                        string temp = Console.ReadLine();
                        answer = Convert.ToDouble(temp);
                        //break only if the cast is successfull
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid answer. Please try again.");
                        continue;
                    }
                }
                //checking if the answer is correct
                if (answer == result.value)
                {
                    Console.WriteLine("\n\t\t Nice! You are correct!!");
                    right++;
                }
                else
                {
                    Console.WriteLine("\n\t\t OOPS! You are Wrong!! \n\t\t Right answer is {0}", result.value);
                    wrong++;
                }
                

                //asking if the user wants to exit the game
                Console.WriteLine("To exit the app press Q/q");
                string exit = Console.ReadLine();
                if (exit != null || exit != "")
                {
                    exit = exit.ToLower();
                    //checking the response
                    if (exit == "q")
                    {
                        //displaying how many answers were right and how many were wrong
                        Console.WriteLine("\n\n Your answeres: \n\t\t correct -- {0} \n\t\t wrong -- {1}", right, wrong);
                        
                        //adding an entry to the file to keep log
                        string log = "User " + name + " : logged on: " + DateTime.Now + "\ncorrect : " + right +
                            " and wrong: " + wrong + "\n" ;

                        File.AppendAllText("log.txt", log);

                        Console.WriteLine("\n\n\t\t  See you later bye");
                        Console.ReadKey();
                        break;
                    }
                    //otherwise continue
                    else
                        continue;
                }

            }






        }
    }
}
