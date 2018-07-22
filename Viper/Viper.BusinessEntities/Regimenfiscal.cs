﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Viper.BusinessEntities
{
    public class RegimenFiscal
    {
        /// <summary>
        /// Campo Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Campo Key
        /// </summary>
        [Required(ErrorMessage = "El campo Key es obligatorio")]
        [StringLength(6, MinimumLength = 1)]
        [DataType(DataType.Text)]
        public string Key { get; set; }

        /// <summary>
        /// Campo Description
        /// </summary>
        [Required(ErrorMessage = "El campo Description es obligatorio")]
        [StringLength(200, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        /// <summary>
        /// Campo Fisica
        /// </summary>
        [Required(ErrorMessage = "El campo Fisica es obligatorio")]
        public byte Fisica { get; set; }

        /// <summary>
        /// Campo Moral
        /// </summary>
        [Required(ErrorMessage = "El campo Moral es obligatorio")]
        public byte Moral { get; set; }
    }
}
