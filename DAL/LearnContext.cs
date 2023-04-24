﻿using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class LearnContext : DbContext
    {
        //Rafi
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Ques> ques { get; set; }

        //Sufian
        public DbSet<Student> students { get; set; }
        public DbSet<Payment> payments { get; set; }


        //mushfiq
        public DbSet<Guardian> guardians { get; set; }

    }
}
