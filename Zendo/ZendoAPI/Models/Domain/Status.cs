namespace ZendoAPI.Models.Domain
{
    public class Status
    {
        private Guid id;
        private String name;
        private int order;

        public Guid Id { get { return id; } }
        public String Name { get { return name; } set { name = value; } }
        public int Order { get { return order; } set { order = value; }  }
    }
}
