using EFCoreCRUDPerformance.Model;
using System;
using System.Linq;

namespace EFCoreCRUDPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTestDataHelper helper = new CreateTestDataHelper();
            ServerContext context = new ServerContext();
            helper.Context = context;
            Console.WriteLine("Context is created. Press enter");
            Console.ReadLine();
            var entities = context.GetEntities<Accountant>().ToList();
            Console.WriteLine("Loaded to memory");
            Console.ReadLine();

            Console.WriteLine("Context is created. Press enter");
            Console.ReadLine();
            entities = context.GetEntities<Accountant>().ToList();
            Console.WriteLine("Loaded to memory");
            Console.ReadLine();

            Console.WriteLine("Accountantn is starting. Press enter");
            Console.ReadLine();
            var entities2 = context.GetEntities<Backpack>().ToList();
            Console.WriteLine("Loaded to memory");
            Console.ReadLine();

            Console.WriteLine("backpack is created. Press enter");
            Console.ReadLine();
            context.GetEntities<Student>().ToList();
            Console.WriteLine("Loaded to memory");
            Console.ReadLine();

            Console.WriteLine("Student is created. Press enter");
            Console.ReadLine();
            context.GetEntities<ExamTable>().ToList();
            Console.WriteLine("Loaded to memory");
            Console.ReadLine();

            Console.WriteLine("ExamTable is created. Press enter");
            Console.ReadLine();
            context.GetEntities<Teacher>().ToList();
            Console.WriteLine("Loaded to memory");
            Console.ReadLine();

            Console.WriteLine("Teacher is created. Press enter");
            Console.ReadLine();
            context.GetEntities<Contact>().ToList();
            Console.WriteLine("Loaded to memory");
            Console.ReadLine();

            Console.WriteLine("Contact to ended");
            Console.ReadLine();
        }

        static void TestCreateAndSave()
        {
            Console.ReadLine();
            CreateTestDataHelper helper = new CreateTestDataHelper();
            ServerContext context = new ServerContext();
            helper.Context = context;
            Console.WriteLine("Context created!");
            Console.ReadLine();
            helper.CreateContactTestData();
            Console.WriteLine("Creating ended!");
            Console.ReadLine();
            context.SaveChanges();
            Console.WriteLine("Finished!");
            Console.ReadLine();
        }
    }
}
