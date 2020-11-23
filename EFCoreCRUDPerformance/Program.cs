using EFCoreCRUDPerformance.Model;
using System;

namespace EFCoreCRUDPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTestDataHelper helper = new CreateTestDataHelper();
            using (ServerContext context = new ServerContext())
            {
                helper.Context = context;
                helper.CreateAccountantTestData();
                helper.CreateBackpackTestData();
                helper.CreateContactTestData();
                helper.CreateExamTestData();
                helper.CreateStudentTestData();
                helper.CreateTeacherTestData();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
