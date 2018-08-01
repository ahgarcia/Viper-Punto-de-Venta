﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Viper.BusinessEntities
{
    public class User
    {
        /// <summary>
        /// Campo Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Campo LoginID
        /// </summary>
        [Required(ErrorMessage = "El campo LoginID es obligatorio")]
        [StringLength(256, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string LoginID { get; set; }

        /// <summary>
        /// Campo PasswordEncrypted
        /// </summary>
        [Required(ErrorMessage = "El campo PasswordEncrypted es obligatorio")]
        [StringLength(30, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string PasswordEncrypted { get; set; }

        /// <summary>
        /// Campo MobilePin
        /// </summary>
        [Required(ErrorMessage = "El campo MobilePins es obligatorio")]
        [StringLength(50, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string MobilePIN { get; set; }

        /// <summary>
        /// Campo EmailAddress
        /// </summary>
        [StringLength(50, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Campo PasswordQuestion
        /// </summary>
        [Required(ErrorMessage = "El campo PasswordQuestion es obligatorio")]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string PasswordQuestion { get; set; }

        /// <summary>
        /// Campo PasswordAnswer
        /// </summary>
        [Required(ErrorMessage = "El campo PasswordAnswer es obligatorio")]
        [StringLength(100, MinimumLength = 2)]
        [DataType(DataType.Text)]
        public string PasswordAnswer { get; set; }

        /// <summary>
        /// Campo AccessFailed
        /// </summary>
        [Required(ErrorMessage = "El campo AccessFailed es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Por favor ingresa un numero entero valido")]
        public int AccessFailed { get; set; }

        /// <summary>
        /// Campo IsWelcome
        /// </summary>
        [Required(ErrorMessage = "El campo IsWelcome es obligatorio")]
        public bool IsWelcome { get; set; }

        /// <summary>
        /// Campo IsApproved
        /// </summary>
        [Required(ErrorMessage = "El campo IsApproved es obligatorio")]
        public bool IsApproved { get; set; }

        /// <summary>
        /// Campo IsActive
        /// </summary>
        [Required(ErrorMessage = "El campo IsActive es obligatorio")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Campo IsEnabled
        /// </summary>
        [Required(ErrorMessage = "El campo IsEnabled es obligatorio")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Campo EmployeeId
        /// </summary>
        [Required(ErrorMessage = "El campo EmployeeID es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Por favor ingresa un numero entero valido")]
        public int EmployeeId { get; set; }

        /// <summary>
        /// Campo EmployeeId
        /// </summary>
        [Required(ErrorMessage = "El campo RoleID es obligatorio")]
        [Range(0, int.MaxValue, ErrorMessage = "Por favor ingresa un numero entero valido")]
        public int RoleId { get; set; }

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
