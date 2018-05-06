﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class EmptyConditions : ICondition
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            return Tuple.Create(true, "");
        }
    }
}
