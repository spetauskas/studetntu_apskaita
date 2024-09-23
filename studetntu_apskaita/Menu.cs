using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;


namespace studetntu_apskaita.Entities
{
    class Menu
    {
        static List<Student> students = new List<Student>();

        public void MenuDisplay()
        {
            while (true)
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Delete student by ID");
                Console.WriteLine("3. Check student list");
                Console.WriteLine("4. Find student by ID");
                Console.WriteLine("5. Find student by name");
                Console.WriteLine("6. Exit program");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            DeleteStudent();
                            break;
                        case 3:
                            CheckStudentList();
                            break;
                        case 4:
                            FindStudentById();
                            break;
                        case 5:
                            FindStudentByName();
                            break;
                        case 6:
                            Console.WriteLine("Exiting program. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Student Number: ");
            if (int.TryParse(Console.ReadLine(), out int studentNumber))
            {
                Console.Write("Enter Email: ");
                string email = Console.ReadLine();
                Console.Write("Enter Department Code: ");
                string departmentCode = Console.ReadLine();

                students.Add(new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    StudentId = studentNumber,
                    Email = email,
                    DepartmentCode = departmentCode
                });
                Console.WriteLine("Student added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid student number. Student not added.");
            }
        }

        static void DeleteStudent()
        {
            Console.Write("Enter Student Number to delete: ");
            if (int.TryParse(Console.ReadLine(), out int studentNumber))
            {
                Student studentToRemove = students.FirstOrDefault(s => s.StudentNumber == studentNumber);
                if (studentToRemove != null)
                {
                    students.Remove(studentToRemove);
                    Console.WriteLine("Student deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid student number.");
            }
        }

        static void CheckStudentList()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students in the list.");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
        }

        static void FindStudentById()// cia reiktu paduoti studento id is DB
        {
            Console.Write("Enter Student Number to find: ");
            if (int.TryParse(Console.ReadLine(), out int studentNumber))
            {
                Student foundStudent = students.FirstOrDefault(s => s.StudentNumber == studentNumber);
                if (foundStudent != null)
                {
                    Console.WriteLine("Student found: " + foundStudent);
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid student number.");
            }
        }

        static void FindStudentByName()
        {
            Console.Write("Enter Student's First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Student's Last Name: ");
            string lastName = Console.ReadLine();

            var foundStudents = students.Where(s =>
                s.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                s.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundStudents.Any())
            {
                Console.WriteLine("Students found:");
                foreach (var student in foundStudents)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("No students found with the given name.");
            }
        }
    }
}