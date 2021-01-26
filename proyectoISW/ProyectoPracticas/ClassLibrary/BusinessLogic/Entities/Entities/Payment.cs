﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Payment
    {
        public DateTime Date
        {
            get;
            set;
        }
        public String Description
        {
            get;
            set;
        }
        public int Id
        {
            get;
            set;
        }
        public double Quantity
        {
            get;
            set;
        }
    }
}