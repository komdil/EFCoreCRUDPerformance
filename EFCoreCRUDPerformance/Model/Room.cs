namespace EFCoreCRUDPerformance.Model
{
    public class Room : Entity
    {
        public string Name { get; set; }
        public int Floor { get; set; }
        public virtual Accountant AccountantCabinet { get; set; }
    }
}
