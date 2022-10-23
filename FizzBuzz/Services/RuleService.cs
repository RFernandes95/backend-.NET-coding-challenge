using FizzBuzz.Enums;
using FizzBuzz.Interfaces;
using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services
{
    public class RuleService : IRuleService
    {

        //new rules can be added here according to the rule object pattern
        public List<Rule> AddRules()
        {
            List<Rule> rules = new List<Rule>();
            rules.Add(new DivideRule { Comparation = DivideComparation.WithoutRemainder, OperationNumber = 3, Output = "Fizz" });
            rules.Add(new DivideRule { Comparation = DivideComparation.WithoutRemainder, OperationNumber = 5, Output = "Buzz" });
            //rules.Add(new DivideRule { Comparation = DivideComparation.WithoutRemainder, OperationNumber = 7, Output = "Bar" });
            //rules.Add(new MultiplyRule { Comparation = MultiplyComparation.Higherthan, OperationNumber = 10, ComparationNumber = 100, Output = "Foo" });

            return rules;
        }
    }
}
