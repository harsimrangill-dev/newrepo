using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    interface IGetOperator
    {

        //interface containting methods that has to implemented by the inheriting calsses
        //here it is for getting the value of the operator from number to expresion.

        string getOperator(card opt);
        

    
    
    }
}
