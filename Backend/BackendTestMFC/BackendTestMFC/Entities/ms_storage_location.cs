using Microsoft.EntityFrameworkCore;

namespace BackendTestMFC.Entities
{
    [Keyless]
    public class ms_storage_location
    {
        public string location_id { get; set; }
        public string location_name { get; set; }

    }
}
