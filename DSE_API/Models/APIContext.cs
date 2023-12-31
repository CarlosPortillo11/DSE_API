﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace DSE_API.Models
{
    public class APIContext : DbContext
    {

        public APIContext(DbContextOptions<APIContext> options) : base(options) { }

        public DbSet<Cuenta> Cuenta { get; set; }

        public DbSet<Transaccion> Transaccion { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            base.ConfigureConventions(builder);
        }

    }
}
