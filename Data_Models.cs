using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentApp3
{
    public class Data_Models
    {
        [AutoIncrement,PrimaryKey,Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Images { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
