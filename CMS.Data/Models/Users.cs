using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using CMS.Core.enums;
using System.ComponentModel.DataAnnotations;
using CMS.Core.enums;
using Microsoft.AspNetCore.Identity;

namespace CMS.Data.Models
{
    public class Users : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }
     
        public string ImageUrl { get; set; }

        public UserType UserType { get; set; }

public bool IsDelete { get; set; }


public DateTime CreatedAt { get; set; }

public string CreatedBy { get; set; }

public DateTime? UpdatedAt { get; set; }

public string UpdatedBy { get; set; }

public List<Posts> Posts   { get; set; }

public List<PostAttacment> PostAttacments { get; set; }

public List<Track> Tracks { get; set; }
public List<Advertisement> Advertisements { get; set; }

public List<Email> Emails { get; set; }
public List<Notification> notifications {get; set;}


    }
}