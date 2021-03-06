﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hit_The_Keys
{
    class Stats
    {
        public int Total { get; set; }
        public int Missed { get; set; }
        public int Correct { get; set; }
        public int Accuracy { get; set; }

        public void Update(bool correctKey)
        {
            Total++;

            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = 100 * Correct / Total ;
        }

        public void Initialize() {
            Total = 0;
            Missed = 0;
            Correct = 0;
            Accuracy = 0;
        }
    }
}
