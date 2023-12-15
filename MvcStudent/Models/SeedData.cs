using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcStudent.Data;
using System;
using System.Linq;

namespace MvcStudent.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudentContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }
                context.Student.AddRange(
                    new Student
                    {
                        StudentName = "Michael Cruz",
                        StudentAddress = "5212 Aspen Rd.",
                        StudentZip = "77742",
                        StudentCity = "Houston",
                        StudentState = "Texas"
                    },
                    new Student
                    {                   
                        StudentName = "Daniel Lee",
                        StudentAddress = "1287 Pen St.",
                        StudentZip = "73254",
                        StudentCity = "Houston",
                        StudentState = "Texas"
                    },
                    new Student
                    {       
                        StudentName = "Isabell Jackson",
                        StudentAddress = "9785 North Ln.",
                        StudentZip = "79322",
                        StudentCity = "Houston",
                        StudentState = "Texas"
                    },
                    new Student
                    {                   
                        StudentName = "Craig Willams",
                        StudentAddress = "4612 York Rd.",
                        StudentZip = "74589",
                        StudentCity = "Houston",
                        StudentState = "Texas"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
