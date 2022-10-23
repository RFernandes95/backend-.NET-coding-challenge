using FizzBuzz.Interfaces;
using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public int limit;

        public FizzBuzzService(int limit)
        {
            this.limit = limit;
        }

        public void Run()
        {
            IRuleService ruleService = new RuleService();
            List<Rule> rules = ruleService.AddRules();

            FizzBuzzEngine engine = new FizzBuzzEngine(rules);

            for(int i = 1; i<=limit; ++i)
            {
                string result = engine.BuildLogic(i);

                if (String.IsNullOrEmpty(result)) {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    Console.WriteLine($"{result}");
                }
            }

        }
    }
}
