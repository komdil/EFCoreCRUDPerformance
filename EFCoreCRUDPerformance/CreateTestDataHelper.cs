using EFCoreCRUDPerformance.Model;
using System;

namespace EFCoreCRUDPerformance
{
    public class CreateTestDataHelper
    {
        public ServerContext Context { get; set; }
        public int AccountantCount = 50;
        public int BackpackCount = 50;
        public int StudentCount = 50;
        public int ExamTableCount = 50;
        public void CreateAccountantTestData()
        {
            for (int i = 0; i < AccountantCount; i++)
            {
                var cabinetRoom = new Room() { Guid = Guid.NewGuid(), Name = $"ROOM{i}", Floor = i };

                var primaryContact = CreateContact(i);

                var accountant = new Accountant()
                {
                    Guid = Guid.NewGuid(),
                    FirstName = $"AccountantFirstName{i}",
                    LastName = $"AccountantLastName{i}",
                    Password = $"Password{i}",
                    Role = UserRole.Accountant,
                    UserName = $"accountant{i}",
                    WorkExperince = "{i} Years",
                    Cabinet = cabinetRoom,
                    PrimaryContact = primaryContact,
                };
                Context.Add(accountant);
            }
        }

        public void CreateBackpackTestData()
        {
            var parent = new Parent() { Guid = Guid.NewGuid() };
            var student = CreateStudent(0, parent);
            for (int i = 0; i < BackpackCount; i++)
            {
                if (i % 2 == 0)
                {
                    student = CreateStudent(i, parent);
                }
                var backpack = new Backpack()
                {
                    Guid = Guid.NewGuid(),
                    Color = $"RGB({i})",
                    Logo = $"XYZ{i}",
                    Student = student,
                    Weight = 123 + i,
                };
                Context.Add(backpack);
            }
        }

        public void CreateStudentTestData()
        {
            Parent parent = null;
            for (int i = 0; i < StudentCount; i++)
            {
                if (i % 2 == 0)
                {
                    parent = new Parent() { Guid = Guid.NewGuid() };
                }
                var student = CreateStudent(i, parent);

                Context.Add(student);
            }
        }

        public void CreateExamTestData()
        {
            for (int i = 0; i < ExamTableCount; i++)
            {
                var exam = new ExamTable()
                {
                    Guid = Guid.NewGuid(),
                    Time = DateTime.Today,
                    Assistant = CreateTeacher(i),
                    Class = CreateClass(i),
                };
                Context.Add(exam);
            }
        }

        public void CreateTeacherTestData()
        {
            for (int i = 0; i < 50; i++)
            {
                var teacher = CreateTeacher(i);
                Context.Add(teacher);
            }
        }

        public void CreateContactTestData()
        {
            for (int i = 0; i < 50; i++)
            {
                var contact = CreateContact(i);
                Context.Add(contact);
            }
            // Context.SaveChanges();
        }

        #region Helpers

        Contact CreateContact(int i)
        {
            var primaryContact = new Contact()
            {
                Guid = Guid.NewGuid(),
                Address = $"Address{i}",
                PhoneNumber = $"+99299999999{i}",
                Country = $"Country{i}",
            };
            return primaryContact;
        }


        Class CreateClass(int i)
        {
            return new Class
            {
                Guid = Guid.NewGuid(),
                ClassType = "Cool",
                Name = $"Class{i}",
            };
        }

        Teacher CreateTeacher(int i)
        {
            var teacher = new Teacher
            {
                Guid = Guid.NewGuid(),
                FirstName = $"Teacher{i}",
                LastName = $"Teacher{i}",
                Role = UserRole.Teacher,
                Password = $"password{i}",
                UserName = $"teacher{i}",
                PrimaryContact = CreateContact(i)
            };

            return teacher;
        }

        Student CreateStudent(int i, Parent parent)
        {
            var primaryContact = new Contact()
            {
                Guid = Guid.NewGuid(),
                Address = $"Address{i}",
                PhoneNumber = $"+99299999999{i}",
                Country = $"Country{i}",
            };

            var student = new Student()
            {
                Guid = Guid.NewGuid(),
                FirstName = $"StudentName{i}",
                LastName = $"StudentLastName{i}",
                Role = UserRole.Student,
                Parent = parent,
                Password = $"StudentPassword{i}",
                UserName = $"student{i}",
                PrimaryContact = primaryContact,
            };
            return student;
        }
        #endregion
    }
}
