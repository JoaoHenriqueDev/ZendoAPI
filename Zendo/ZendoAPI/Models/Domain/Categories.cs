namespace ZendoAPI.Models.Domain
{
    public class Categories
    {
        private Guid id;
        private String name;

        public Guid Id { get { return id; } }
        public String Name { get { return name; } set { name = value; } }
    }
}
