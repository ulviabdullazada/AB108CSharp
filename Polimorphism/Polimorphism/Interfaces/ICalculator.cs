﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Interfaces
{
    interface ICalculator:IAdd, IDivide, IDifference, IMultiply
    {
    }
    interface IAdd
    {
        float Add(float num1, float num2);
    }
    interface IDifference
    {
        float Diff(float num1, float num2);
    }
    interface IDivide
    {
        float Divide(float num1, float num2);
    }
    interface IMultiply
    {
        float Multiply(float num1, float num2);
    }

}