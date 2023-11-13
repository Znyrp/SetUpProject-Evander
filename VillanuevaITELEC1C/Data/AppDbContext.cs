using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using VillanuevaITELEC1C.Models;
namespace VillanuevaITELEC1C.Data;

    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //Data Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // do not remove this!

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    StudentFirstName = "Evander Prynz",
                    StudentLastName = "Villanueva",
                    Email = "evanderprynz.villanueva.cics@ust.edu.ph",
                    StudentCourse = Course.BSIT,
                    GPA = 1.00,
                    PhoneNumber = "123-456-8910",
                    DateEnrolled = DateTime.Parse("02/01/2020")
                },
                 new Student()
                 {
                     Id = 2,
                     StudentFirstName = "Jan Drefner",
                     StudentLastName = "Santos",
                     Email = "jandrefner.santos.cics@ust.edu.ph",
                     StudentCourse = Course.BSIT,
                     GPA = 1.25,
                     PhoneNumber = "124-356-1910",
                     DateEnrolled = DateTime.Parse("03/02/2020")
                 },
                  new Student()
                  {
                      Id = 3,
                      StudentFirstName = "Mark Clarence",
                      StudentLastName = "Alicante",
                      Email = "markclarence.alicante.cics@ust.edu.ph",
                      StudentCourse = Course.BSCS,
                      GPA = 1.50,
                      PhoneNumber = "122-156-2910",
                      DateEnrolled = DateTime.Parse("22/01/2020")
                  },
                   new Student()
                   {
                       Id = 4,
                       StudentFirstName = "Zyke",
                       StudentLastName = "Victoria",
                       Email = "zyke.victoria.cics@ust.edu.ph",
                       StudentCourse = Course.BSIS,
                       GPA = 1.25,
                       PhoneNumber = "112-426-8100",
                       DateEnrolled = DateTime.Parse("10/11/2020"),
                   },
                    new Student()
                    {
                        Id = 5,
                        StudentFirstName = "Louis Ivan",
                        StudentLastName = "Virgo",
                        Email = "louisivan.virgo.cics@ust.edu.ph",
                        StudentCourse = Course.BSIT,
                        GPA = 1.75,
                        PhoneNumber = "113-426-8110",
                        DateEnrolled = DateTime.Parse("03/02/2020")
                    }
                );


            modelBuilder.Entity<Instructor>().HasData(
               new Instructor()
               {
                   Id = 1,
                   FirstName = "Leonid",
                   LastName = "Lintag",
                   IsTenured = true,
                   Rank = Rank.Instructor,
                   HiringDate = DateTime.Parse("02/01/2020"),
                   OfficePhone = "114-436-8210"

               },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Eugenia",
                    LastName = "Zhuo",
                    IsTenured = true,
                    Rank = Rank.Professor,
                    HiringDate = DateTime.Parse("02/01/2020"),
                    OfficePhone = "124-136-9210"
                },
                 new Instructor()
                 {
                     Id = 3,
                     FirstName = "Gabriel",
                     LastName = "Montano",
                     IsTenured = true,
                     Rank = Rank.AssistantProfessor,
                     HiringDate = DateTime.Parse("02/01/2020"),
                     OfficePhone = "114-536-3310"
                 },
                  new Instructor()
                  {
                      Id = 4,
                      FirstName = "Mike",
                      LastName = "Victorio",
                      IsTenured = false,
                      Rank = Rank.AssociateProfessor,
                      HiringDate = DateTime.Parse("02/01/2020"),
                      OfficePhone = "224-326-8190"
                  }
               );
        }
    }
