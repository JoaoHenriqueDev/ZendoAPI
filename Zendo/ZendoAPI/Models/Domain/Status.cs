namespace ZendoAPI.Models.Domain
{
    public class Status
    {
        public Guid Id { get; set; }
        private String name;
        private int order;

        public String Name { get { return name; } set { name = value; } }
        public int Order { get { return order; } set { order = value; }  }
    }
}
