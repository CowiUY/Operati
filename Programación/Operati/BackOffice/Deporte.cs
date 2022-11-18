namespace BackOffice
{
    public class Deporte
    {

        public int ID_Deporte { get; set; }

        public string Nom_Deporte { get; set; }

        public string Categoria_Deporte { get; set; }


    }


    public class Deportes_Categorizados
    {

        public int ID_Deporte { get; set; }

        public int ID_Categoria { get; set; }

        public string Nom_Deporte { get; set; }

        public string Nom_Categoria { get; set; }








    }


}
