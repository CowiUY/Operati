using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class Encuentro
    {
        public int ID_Encuentro    { get; set; }
        public int ID_Deporte      { get; set; }
        public int ID_Categoria    { get; set; }
        public int ID_Persona      { get; set; }
        public string Hora         { get; set; }
        public string Fecha        { get; set; }
        public string Nombre       { get; set; }


    }

    public class Puntuacion
    {

        public int ID_Puntuacion   { get; set; }
        public int Puntua          { get; set; }
        public int ID_Encuentro    { get; set; }

    }

    public class Arbitro
    {
   
        public int ID_Persona      { get; set; }
        public string Nombre       { get; set; }
        public string Apellido     { get; set; }
        public string Nacioanlidad { get; set; }

    }
}
