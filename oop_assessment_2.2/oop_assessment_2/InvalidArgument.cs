using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assessment_2
{
    //custom exception class
    class InvalidArgumentException: Exception
    {
        public InvalidArgumentException(string message): base(message)
        {

        }
    }
}
