using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentApp3
{
    public class PostModels
    {
        [AutoIncrement, PrimaryKey, Column("id")]
        public int Id { get; set; }
        public int Id_from_User {get; set; }
        public string name { get; set; }
        public byte[] image { get; set; }
        public byte[] ImagePOST { get; set; }
        public byte[] videoPOST { get; set; }
        public byte[] audioPOST { get; set; }
        public string txtPOST { get; set; }
    }
}
