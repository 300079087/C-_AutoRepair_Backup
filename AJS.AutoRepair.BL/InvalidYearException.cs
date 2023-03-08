using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJS.AutoRepair.BL
{
    public class InvalidYearException : Exception
    {
        // properties
        public int InvalidYear { get; set; }

        // constructor
        public InvalidYearException(int invalidYear)
            // use the Exception constructor that takes a string param
            : base(invalidYear + " is not valid")
        {
            InvalidYear = invalidYear;
        }
    }
}
