﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viper.BusinessEntities
{
    public class Shift
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(40, ErrorMessage = "The field Name must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Name must be a string")]
        public String Name { get; set; }

        [Required(ErrorMessage = "The field StartTime is required")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "The field EndTime is required")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public virtual ICollection<EmployeeDepartmentHistory> EmployeesDepartmentHistory { get; set; }
    }
}