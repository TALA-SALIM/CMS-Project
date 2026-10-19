
using CMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data;

public class CMSDbContext : IdentityDbContext<Users>
{
    public CMSDbContext(DbContextOptions<CMSDbContext> options)
        : base(options)
    {
    }

    public DbSet<Posts> Posts { get; set; }
    public DbSet<PostAttacment> PostAttacments { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<Email> Emails { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Advertisement> Advertisements { get; set; }
    public DbSet<ContentChangeLog> ContentChangeLogs { get; set; }
}

