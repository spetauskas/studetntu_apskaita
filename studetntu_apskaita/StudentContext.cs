using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studetntu_apskaita.Entities;


namespace studetntu_apskaita
{
    internal class StudentContext : DbContext
    {
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Departament> Departaments { get; set; }


        public StudentContext() : base() { }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { } //konstruktorius su parametrais reikalingas testavimui.


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentuApskaita;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departament>()
                .HasData(CsvHelper.GetDepartament());

            modelBuilder.Entity<Student>()
                .HasData(CsvHelper.GetStudents());

            modelBuilder.Entity<Departament>()
                .HasData(CsvHelper.GetStudents());

        }

    }
}

    
