﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Viper.BusinessEntities
{
    public class Shift
    {
        public int id { get; set; }



        public string Name { get; set; }



        public TimeSpan StartTime { get; set; }



        public TimeSpan EndTime { get; set; }



        public DateTime CreatedDate { get; set; }



        public string CreateBy { get; set; }



        public DateTime ModifiedDate { get; set; }



        public string ModifiedBy { get; set; }
    }
}
