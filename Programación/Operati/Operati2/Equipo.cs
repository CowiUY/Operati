using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class Equipo
    {
        public int ID_Equipo { get; set; }
        public string Nom_Equipo { get; set; }
        public string Pais_Origen { get; set; }

    }

    public class EquiposDeDeportistas
    {
        public int ID_Equipo { get; set; }
        public int ID_Persona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacionalidad { get; set; }

    }



}
