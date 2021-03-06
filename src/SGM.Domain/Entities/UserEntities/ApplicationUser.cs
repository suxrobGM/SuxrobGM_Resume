﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using SGM.Domain.Interfaces.Entities;
using SuxrobGM.Sdk.Utils;

namespace SGM.Domain.Entities.UserEntities
{
    public class ApplicationUser : IdentityUser<string>, IEntity<string>
    {
        public ApplicationUser()
        {
            ProfilePhotoPath = "/img/default_user_avatar.png";
            Timestamp = DateTime.Now;
        }

        [Display(Name = "ID")]
        public override string Id { get; set; } = GeneratorId.GenerateComplex();

        [StringLength(40, ErrorMessage = "Characters must be less than 40")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(40, ErrorMessage = "Characters must be less than 40")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(64)]
        [Display(Name = "Profile Photo Path")]
        public string ProfilePhotoPath { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime Timestamp { get; set; }
    }
}
