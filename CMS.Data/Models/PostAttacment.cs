using System;
using System.Collections.Generic;   
using System. Linq;
using System. Text; 
using System. Threading. Tasks;
using System.ComponentModel.DataAnnotations;
namespace CMS.Data.Models
{   

public class PostAttacment{

public int Id { get; set; }

public int PostId { get; set; }
public Posts Post { get; set; }
   [Required]

public string AttacmentUrl { get; set; }

}}

