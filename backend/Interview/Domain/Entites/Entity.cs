namespace Domain.Entites
{
    public abstract class Entity
    {
        public Entity()
        {
            CreationDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
