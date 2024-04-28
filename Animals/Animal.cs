﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        public int Legs { get; set; }
        public bool CanFly { get; set; }
        public int AverageLifeExpectancy { get; set; }

        public Animal(int legs, bool canFly,
            int averageLifeExpectancy)
        {
            Legs = legs;
            CanFly = canFly;
            AverageLifeExpectancy = averageLifeExpectancy;
        }

        public override string ToString()
        {
            string fly = "cannot";
            if (CanFly) fly = "can";

            return "This animal has " + Legs
                + " legs and " + fly + " fly.";

            // voorbeeld: This animal has 4 legs and cannot fly.
        }
    }
}