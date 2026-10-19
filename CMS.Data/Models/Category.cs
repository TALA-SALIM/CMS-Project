using System;
using System.Collections.Generic;
using System.Linq;
using System. Text;
using System. Threading. Tasks;
using System.ComponentModel.DataAnnotations;
namespace CMS.Data.Models
{


public class Category : BaseEntity
{


public int Id { get; set; }

   [Required]

public string Name { get; set; }


public List<Posts> Posts { get; set; } 
public List<Track> Tracks { get; set; }

}}