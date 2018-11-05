using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// add by AWR
using System.ComponentModel.DataAnnotations;

namespace MVC1st.Models
{
    public class SQLServerUserAccount
    {
        /// <summary>
        /// Code First: https://www.youtube.com/watch?v=Uq0y8oxnx-8
        /// </summary>

            [Key]
            public int UserID { get; set; }

            [Required(ErrorMessage = "Login is required.")]
            public string UserLogin { get; set; }

            [Required(ErrorMessage = "Password is required.")]
            [DataType(DataType.Password)]
            public string UserPassword { get; set; }

            [Required(ErrorMessage = "Password is required.")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirm Password")]
            [Compare("UserPassword", ErrorMessage = "Please confirm the password.")]
            public string UserPasswordConfirm { get; set; }

            [Required(ErrorMessage = "E-mail is required.")]
            [DataType(DataType.EmailAddress)]
            public string UserEmail { get; set; }


            public bool IsAdmin { get; set; }

        
    }
}