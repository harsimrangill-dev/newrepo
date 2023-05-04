using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    interface Icalculation
    {
        //intreface contains method for calculating objects of type data

        //two values and one operator
        card calculate(card c1, card opt, card c2);

        //three values and two operator
        card calculate(card c1, card opt1, card c2, card opt2, card c3);

    }
}
