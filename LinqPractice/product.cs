﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    internal class product
    {

        public string Name{get; set;}
        public int Price { get; set;}
        public override string ToString()
        {
            return Name + ": " + Price +"원";

        }

    }
}
