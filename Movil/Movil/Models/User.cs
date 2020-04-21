using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movil.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int Email { get; set; }
        public int Password { get; set; }
        public int Nombre { get; set; }
        public int Apellido { get; set; }
        public int Edad { get; set; }
        public int Ciudad { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
