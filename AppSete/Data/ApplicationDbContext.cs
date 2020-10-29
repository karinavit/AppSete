using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppSete.Models;

namespace AppSete.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AppSete.Models.TipoUsuario> TipoUsuario { get; set; }
        public DbSet<AppSete.Models.AcessoTipoUsuario> AcessoTipoUsuario { get; set; }
        public DbSet<AppSete.Models.PerfilUsuario> PerfilUsuario { get; set; }
    }
}
