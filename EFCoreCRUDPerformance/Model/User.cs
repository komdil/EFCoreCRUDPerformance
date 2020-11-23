namespace EFCoreCRUDPerformance.Model
{
    public class User : Person
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        None,
        Student,
        Teacher,
        Accountant,
        Director
    }
}