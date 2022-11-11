using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOffice
{
    public class Encuentro
    {
        public int ID_Encuentro        { get; set; }
        public int ID_Deporte          { get; set; }
        public int ID_Categoria        { get; set; }
        public int ID_Persona          { get; set; }
        public string Hora             { get; set; }
        public string Fecha            { get; set; }
        public string Nom_Encuentro    { get; set; }
    }

    public class Round
    {
        public int Num_Round           { get; set; }
        public int ID_Encuentro        { get; set; }
        public int ID_Puntuacion       { get; set; }
    }

    public class PuntuacionRound
    {
        public int ID_Puntuacion       { get; set; }
        public int Puntua              { get; set; }
        public int ID_Encuentro        { get; set; }
    }

    public class Arbitro
    {
        public int ID_Persona          { get; set; }
        public string Nom_Arbitro      { get; set; }
        public string Ape_Arbitro      { get; set; }
        public string Nacionalidad     { get; set; }
    }

    public class EncuentrosEquipo
    {
        public int ID_Encuentro        { get; set; }
        public int ID_Equipo           { get; set; }
        public int ID_Deporte          { get; set; }
        public int ID_Categoria        { get; set; }
        public int ID_Persona          { get; set; }
        public string Nom_Equipo       { get; set; }
        public string Nom_Encuentro    { get; set; }
        public string Pais_Origen      { get; set; }
        public string Fecha            { get; set; }
        public string Hora             { get; set; }
        public string Lugar            { get; set; }
        public int Puntuacion          { get; set; }



    }
}
