using System;
using System.Collections.Generic;


namespace oop_assessment_2
{
    class card : Data
    {
        
        //value and suits 

        protected internal int suit { get; set; }
        
        //constructor for card class which also calls data class constructor

        public card(double value, int Operator): base(value)
        {
            suit = Operator;
        }

        //implementing methods to get suits only beacuse we already have values one
        public int getSuit()
        {
            return suit;
        }
        
        //implementing mehthod to set values of suits and values
        //overriding 
        public override void addData(double value)
        {
            this.value = value;
        }
        public void addSuit(int suit)
        {
            this.suit = suit;
        }

        //overriding the tostring method
        public override string ToString()
        {
            return value + "of" + suit;
        }

        //Implementing the Imath mehtods

        //operator methods for easy calculation

        //all the methods has suit field zero

        //addition
        public static  card operator + (card c1, card c2)
        {
            return new card(c1.value + c2.value,0);
        }
        //subtaction
        public static card operator - (card c1, card c2)
        {
            return new card(c1.value - c2.value, 0);
        }
        //multiplication
        
        public static card operator * (card c1, card c2)
        {
            return new card(c1.value * c2.value,0);
        }
        //divide

        public static card operator /(card c1, card c2)
        {
            //temporary fields
            //rounding off the field to nearest 100 so that to easy to answer
            double temp = Math.Round((c1.value / c2.value), 2);
            return new card(temp,0);
        }
    }
}
