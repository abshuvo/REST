﻿using Microsoft.EntityFrameworkCore;
using REST.Models;

namespace REST.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<StudentAttendence> StudentAttendances { get; set; }
    }
}
