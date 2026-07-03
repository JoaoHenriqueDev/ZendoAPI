using ZendoAPI.Models.Enum.user;

namespace ZendoAPI.Models.Domain
{
    public class Usuario
    {
        public Guid Id { get; set; }
        private String name;
        private String email;
        private String password;
        private UserEnum role;
        private UserStatusEnum isActive;
        private DateTime createdAt;
        private DateTime? updatedAt;



        public String Name{get { return name; } set {name = value;}}
        public String Email { get { return email; } set { email = value; }}
        public String Password { get { return password; } set { password = value; }}
        public UserEnum Role { get { return role; } set { role = value; } }
        public UserStatusEnum IsActive { get { return isActive; } set { isActive = value; }}
        public DateTime CreatedAt { get { return createdAt;} set { createdAt = value; } }
        public DateTime? UpdatedAt { get { return updatedAt;} set { updatedAt = value; }}

    }
}
