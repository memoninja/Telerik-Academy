﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;
        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get { return this.town; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            string toStr = "OffsiteCourse: " + base.ToString() + "; Town=" + this.Town;

            return toStr;
        }
    }
}
