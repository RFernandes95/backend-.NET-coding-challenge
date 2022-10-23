using FizzBuzz.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Models
{
    public class Rule
    {
        
        public int OperationNumber { get; set; }
        public string Output { get; set; }
        
    }

    public class DivideRule : Rule
    {
        public DivideComparation Comparation { get; set; }
    }

    public class MultiplyRule : Rule
    {
        public int ComparationNumber { get; set; }
        public MultiplyComparation Comparation { get; set; }
    }
}
