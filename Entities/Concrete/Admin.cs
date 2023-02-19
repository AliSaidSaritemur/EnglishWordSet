
namespace Entities.Concrete
{
    public class Admin
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password{ get; set; }
        public int token { get; set; }
        public string lastEntryDay { get; set; }
    }
}
