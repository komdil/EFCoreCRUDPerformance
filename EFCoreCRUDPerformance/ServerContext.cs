using EFCoreCRUDPerformance.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCoreCRUDPerformance
{
    public class ServerContext : DbContext
    {
        public ServerContext()
        {
            Database.EnsureCreated();
        }

        const string dbName = "EFCoreCRUDPerformance";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=localhost;Database={dbName};Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        public IQueryable<T> GetEntities<T>() where T : class
        {
            return Set<T>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigAccountModel(modelBuilder);
            ConfigAccountantModel(modelBuilder);
            ConfigBackpackModel(modelBuilder);
            ConfigClassModel(modelBuilder);
            ConfigContactModel(modelBuilder);
            ConfigExamStudentLinkModel(modelBuilder);
            ConfigExamTableModel(modelBuilder);
            ConfigMarkModel(modelBuilder);
            ConfigParentModel(modelBuilder);
            ConfigPaymentModel(modelBuilder);
            ConfigRoomModel(modelBuilder);
            ConfigStudentModel(modelBuilder);
            ConfigTeacherModel(modelBuilder);
            ConfigTeacherClassLinkModel(modelBuilder);
            ConfigUserModel(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        void ConfigAccountModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Account>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.PrimaryContact).WithMany(s => s.PrimaryAccounts).HasForeignKey(s => s.PrimaryContactGuid);
            entity.HasMany(s => s.Payments).WithOne(s => s.AccountWhichIsPaying).HasForeignKey(s => s.AccountWhichIsPayingGuid);
        }

        void ConfigAccountantModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Accountant>();
            entity.HasOne(s => s.Cabinet).WithOne(s => s.AccountantCabinet).HasForeignKey<Accountant>(s => s.CabinetGuid);
            entity.HasMany(s => s.ReceivedPayments).WithOne(s => s.Accountant).HasForeignKey(s => s.AccountantGuid);
        }

        void ConfigBackpackModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Backpack>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.Student).WithMany(s => s.Backpacks).HasForeignKey(s => s.StudentGuid);
        }

        void ConfigClassModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Class>();
            entity.HasKey(k => new { k.Guid });
            entity.HasMany(s => s.Marks).WithOne(s => s.Class).HasForeignKey(s => s.ClassGuid);
            entity.HasMany(s => s.TeachersCanTechThisClass).WithOne(s => s.Class).HasForeignKey(s => s.ClassGuid);
        }

        void ConfigContactModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Contact>();
            entity.HasKey(k => new { k.Guid });
            entity.HasMany(s => s.PrimaryAccounts).WithOne(s => s.PrimaryContact).HasForeignKey(s => s.PrimaryContactGuid);
        }

        void ConfigExamStudentLinkModel(ModelBuilder builder)
        {
            var entity = builder.Entity<ExamStudentLink>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.Student).WithMany(s => s.ExamStudentLinks).HasForeignKey(s => s.StudentGuid);
            entity.HasOne(s => s.ExamTable).WithMany(s => s.ExamStudentLinks).HasForeignKey(s => s.ExamTableGuid);
        }

        void ConfigExamTableModel(ModelBuilder builder)
        {
            var entity = builder.Entity<ExamTable>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.Assistant).WithMany(s => s.AssistantToExams).HasForeignKey(s => s.AssistantGuid);
            entity.HasMany(s => s.ExamStudentLinks).WithOne(s => s.ExamTable).HasForeignKey(s => s.ExamTableGuid).OnDelete(DeleteBehavior.NoAction);
        }

        void ConfigMarkModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Mark>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.Class).WithMany(s => s.Marks).HasForeignKey(s => s.ClassGuid).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(s => s.Student).WithMany(s => s.Marks).HasForeignKey(s => s.StudentGuid).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(s => s.Teacher).WithMany(s => s.Marks).HasForeignKey(s => s.TeacherGuid).OnDelete(DeleteBehavior.NoAction);
        }

        void ConfigParentModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Parent>();
            entity.HasKey(k => new { k.Guid });
            entity.HasMany(s => s.Children).WithOne(s => s.Parent).HasForeignKey(s => s.ParentGuid);
        }

        void ConfigPaymentModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Payment>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.AccountWhichIsPaying).WithMany(s => s.Payments).HasForeignKey(s => s.AccountWhichIsPayingGuid).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(s => s.Accountant).WithMany(s => s.ReceivedPayments).HasForeignKey(s => s.AccountantGuid);
        }

        void ConfigRoomModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Room>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.AccountantCabinet).WithOne(s => s.Cabinet).HasForeignKey<Accountant>(s => s.CabinetGuid);
        }

        void ConfigStudentModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Student>();
            entity.HasOne(s => s.Parent).WithMany(s => s.Children).HasForeignKey(s => s.ParentGuid);
            entity.HasMany(s => s.Backpacks).WithOne(s => s.Student).HasForeignKey(s => s.StudentGuid);
            entity.HasMany(s => s.ExamStudentLinks).WithOne(s => s.Student).HasForeignKey(s => s.StudentGuid);
            entity.HasMany(s => s.Marks).WithOne(s => s.Student).HasForeignKey(s => s.StudentGuid);
        }

        void ConfigTeacherModel(ModelBuilder builder)
        {
            var entity = builder.Entity<Teacher>();
            entity.HasMany(s => s.AssistantToExams).WithOne(s => s.Assistant).HasForeignKey(s => s.AssistantGuid);
            entity.HasMany(s => s.Marks).WithOne(s => s.Teacher).HasForeignKey(s => s.TeacherGuid);
        }

        void ConfigTeacherClassLinkModel(ModelBuilder builder)
        {
            var entity = builder.Entity<TeacherClassLink>();
            entity.HasKey(k => new { k.Guid });
            entity.HasOne(s => s.Teacher).WithMany(t => t.TeacherClassLinks).HasForeignKey(s => s.TeacherGuid);
            entity.HasOne(s => s.Class).WithMany(t => t.TeachersCanTechThisClass).HasForeignKey(s => s.ClassGuid);
        }

        void ConfigUserModel(ModelBuilder builder)
        {
            var entity = builder.Entity<User>();
            entity.HasKey(k => new { k.Guid });
        }
    }
}
