using System;
using System.Collections.Generic;
using System.Linq;
using System. Text;
using System. Threading. Tasks;
using System.ComponentModel.DataAnnotations;
namespace CMS.Data.Models
{


public class Email{


public int Id { get; set; }
   [Required]

public string Subject { get; set; }
   [Required]

public string Body { get; set; }

public string UserId { get; set; }

public Users User { get; set; }

public DateTime SendAt { get; set; }

}}