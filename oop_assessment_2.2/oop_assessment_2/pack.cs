using System;
using System.Collections.Generic;


namespace oop_assessment_2
{
    //extending the class by using interfaces

    class pack: Group,IDeal,IShuffle
    {
        //list of math for containg the dealt values => cards
        internal List<card> values = new List<card>();

        //deal method / constructor
        public pack(int val)
        {
            //shuffling the lists
            shuffle(ref numbers);
            shuffle(ref operators);

            card first = new card(deal(numbers), deal(operators));
            card operand = new card(deal(numbers), deal(operators));
            card second = new card(deal(numbers), deal(operators));

            values.Add(first);
            values.Add(operand);
            values.Add(second);
            
            //if it we have to deal 5 cards
            if (val != 1)
            {
                card secondOpt = new card(deal(numbers), deal(operators));
                card third = new card(deal(numbers), deal(operators));
                values.Add(secondOpt);
                values.Add(third);
            }
            
        }


        //method for shuffling the list for numbers and operators
        //particulartly Fisher-Yates shuffle

        public void shuffle(ref List<int> array)
        {
            insert();
            Random rmd = new Random();
            int tempRmd = 0;
            int temp = 0;
            for(int i = array.Count - 1; i < 0; i--)
            {
                tempRmd = rmd.Next(0, i + 1);
                temp = array[tempRmd];
                array[tempRmd] = array[i];
                array[i] = temp;
            }
        }


        //dealing nnumber or operator depending 
        //on the given list, from the shuffled
        //list, and randomly
        public int deal(List<int> intList)
        {
            Random rmd = new Random();
            //temporary field for containing the value
            int temp = intList[rmd.Next(0, intList.Count)];

            //deleting the data is it wont repeate 
            intList.Remove(temp);
            return temp;
        }

    }
}
