using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6WhatsNew.Models
{
    public class EF6WhatsNewContext : DbContext
    {
        public EF6WhatsNewContext() : base("name=EF6WhatsNewContext")
        {
        }

        public DbSet<EF6WhatsNew.Models.Post> Posts { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties().Where(p => p.Name.StartsWith("Pk"))
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Where(p => p.Name.Contains("Title") ||
                       p.Name.Contains("Name") ||
                       p.Name.Contains("Email")
                      ).Configure(p => p.HasMaxLength(200));

            modelBuilder.Properties()
                .Configure(p => p.HasColumnName(GetColumnName(p.ClrPropertyInfo)));
        }

        private string GetColumnName(System.Reflection.PropertyInfo propertyInfo)
        {
            var result = propertyInfo.DeclaringType.Name + "_";

            result += System.Text.RegularExpressions.Regex.Replace(
                propertyInfo.Name,
                ".[A-Z]", m => m.Value[0] + "_" + m.Value[1]);
            return result.ToUpper();
        }
    }
}