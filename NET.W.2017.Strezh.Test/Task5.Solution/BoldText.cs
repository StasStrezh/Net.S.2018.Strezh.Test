﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class BoldText : DocumentPart
    {
        public override string Convert(IConverter converter)
        {
            return converter.Convert(this);
        }
    }
}
