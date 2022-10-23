using FizzBuzz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Interfaces
{
    public interface IRuleService
    {
        List<Rule> AddRules();
    }
}
