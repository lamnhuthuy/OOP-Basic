﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_Override
{
    internal class Calculator
    {
        public Calculator()
        {
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum(int a, int b, int c)
        {
            return (a + b) + c;
        }
        public float Sum(float a, float b)
        {
            return a + b;
        }
        public float Sum(int a, float b)
        {
            var result= (float)a+ b;
            return result;
        }

    }
}
