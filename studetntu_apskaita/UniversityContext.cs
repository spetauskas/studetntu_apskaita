using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studetntu_apskaita.Entities;



namespace studetntu_apskaita
{
    internal class UniversityContext : DbContext
    {
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Departament> Departaments { get; set; }


        public UniversityContext() : base() { }
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options) { } //konstruktorius su parametrais reikalingas testavimui.


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentuApskaita;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define primary keys
            modelBuilder.Entity<Departament>()
                .HasKey(d => d.DepartmentId); // Assuming DepartmentCode is the primary key

            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentId); // Assuming StudentId is the primary key

            modelBuilder.Entity<Lecture>()
                .HasKey(l => l.LectureName); // Assuming LectureName is the primary key

            // Seed data using CsvHelper methods
            var departments = CsvHelper.GetDepartament();
            var students = CsvHelper.GetStudents();
            var lectures = CsvHelper.GetLecture();

            // Seed data with HasData
            modelBuilder.Entity<Departament>()
                .HasData(departments.ToArray());

            modelBuilder.Entity<Student>()
                .HasData(students.ToArray());

            modelBuilder.Entity<Lecture>()
                .HasData(lectures.ToArray());
        }

    }
}

    
