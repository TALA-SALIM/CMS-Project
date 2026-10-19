using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.enums;
using System.ComponentModel.DataAnnotations;

namespace CMS.Data.Models
{
    public class Posts : BaseEntity
    {
       public int Id { get; set; }
   [Required]

public string Title { get; set; }
   [Required]

public string Body { get; set; }

public int TimeInMinute { get; set; }


public int CategoryId { get; set; }

public Category Category { get; set; }

public string AuthorId { get; set; }
public Users Author { get; set; }

public ContentStatus status {get; set;}

public List<PostAttacment> postAttacments {get; set;}

    }
}