namespace ZendoAPI.Models.Domain
{
    public class Categoria
    {
        public Guid Id { get; set; }
        private String name;

        public String Name { get { return name; } set { name = value; } }
    }
}
