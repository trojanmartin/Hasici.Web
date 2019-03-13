﻿

using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hasici.Web
{

    /// <summary>
    /// User for the application
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        [Display(Name ="Meno")]
        public string RealName { get; set; }

        /// <summary>
        /// Sex of the user
        /// </summary>
        [Display(Name ="Pohlavie")]
        public bool Male { get; set; }

        /// <summary>
        /// Articles which user write
        /// </summary>       
        public ICollection<Article> Articles { get; set; }
    }
}
