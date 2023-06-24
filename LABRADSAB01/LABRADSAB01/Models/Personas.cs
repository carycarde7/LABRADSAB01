using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace LABRADSAB01.Models
{
    public class Personas 
    
    {
        [PrimaryKey, AutoIncrement]

        [MaxLength(100), NotNull]
        public int Id { get; set; }
       

        [MaxLength(100), NotNull]
        public string Nombres { get; set; }
        

        [MaxLength(100), NotNull]
        public string Apellidos { get; set; }
        

        [NotNull]
        public DateTime FechaNac { get; set; }
        

        [NotNull, Unique]
        public string Telefono { get; set; }

        public string telefono { get; set; }

        public byte[] foto { get; set;  }

    }
}
