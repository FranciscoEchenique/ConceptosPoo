using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPoo
{
    public class ComissionEmployee : Employee
    {
        public float ComissionPercentage { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ComissionPercentage;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" + 
                $"\n\t Comission percentage: {ComissionPercentage:P2}" +
                $"\n\t Sales...............: {Sales:C2}" +
                $"\n\t Value to pay........: {GetValueToPay():C2}";
        }
    }
}
