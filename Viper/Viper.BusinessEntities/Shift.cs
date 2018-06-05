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
        /// <summary>
        /// Campo Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Campo Name
        /// </summary>
        [Required(ErrorMessage = "El campo Name es obligatorio")]
        [StringLength(50, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        /// <summary>
        /// Campo StartTime
        /// </summary>
        [Required(ErrorMessage = "El campo StartTime es obligatorio")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Campo EndTime
        /// </summary>
        [Required(ErrorMessage = "El campo EndTime es obligatorio")]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Campo CreatedDate
        /// </summary>
        [Required(ErrorMessage = "El campo CreatedDate es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Campo CreateBy
        /// </summary>
        [Required(ErrorMessage = "El campo CreateBy es obligatorio")]
        [StringLength(6, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string CreateBy { get; set; }

        /// <summary>
        /// Campo ModifiedDate
        /// </summary>
        [Required(ErrorMessage = "El campo ModifiedDate es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Campo ModifiedBy
        /// </summary>
        [Required(ErrorMessage = "El campo ModifiedBy es obligatorio")]
        [StringLength(6, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string ModifiedBy { get; set; }
    }
}