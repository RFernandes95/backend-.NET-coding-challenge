using FizzBuzz.Enums;
using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        public List<Rule> rules;

        public FizzBuzzEngine(List<Rule> rules)
        {
            this.rules = rules;
        }

        public string BuildLogic(int number)
        {
            StringBuilder result = new StringBuilder();
            foreach (var rule in rules)
            {
 
                switch (rule)
                {
                    case DivideRule d:
                        if (d.Comparation == DivideComparation.WithoutRemainder)
                        {
                            if (number % rule.OperationNumber == 0)
                                result.Append(rule.Output);
                        }
                        if (d.Comparation == DivideComparation.WithRemainder)
                        {
                            if (number % rule.OperationNumber != 0)
                                result.Append(rule.Output);
                        }
                        break;
                    case MultiplyRule m:
                        if (m.Comparation == MultiplyComparation.HigherThan)
                        {
                            if (number * rule.OperationNumber > m.ComparationNumber)
                                result.Append(rule.Output);
                        }
                        if (m.Comparation == MultiplyComparation.LowerThan)
                        {
                            if (number * rule.OperationNumber < m.ComparationNumber)
                                result.Append(rule.Output);
                        }
                        break;

                    default:
                        break;
                }
            }

            return result.ToString();
        }
    }
}
