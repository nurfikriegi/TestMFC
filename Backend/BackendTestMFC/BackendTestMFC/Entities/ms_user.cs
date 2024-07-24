using Microsoft.EntityFrameworkCore;

namespace BackendTestMFC.Entities
{
    [Keyless]
    public class ms_user
    {
        
        public Int64 user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public Boolean is_active { get; set; }
    }
}
