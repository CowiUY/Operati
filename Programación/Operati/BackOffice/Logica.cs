using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Operati2;

namespace BackOffice
{
    class Logica
    {
        private static DBConnect cbd = new DBConnect();


        //serializacion//

        public static void SerializeUsuarios(List<Usuario> usuarios, string path = "SerialJson\\Usuarios.json")
        {

            string usuariosJsonData = JsonSerializer.Serialize(usuarios);
            File.WriteAllText(path, usuariosJsonData);


        }

        public static void SerializeDeportes(List<Deporte> deportes, string path = "SerialJson\\Deportes.json")
        {

            string deportesJsonData = JsonSerializer.Serialize(deportes);
            File.WriteAllText(path, deportesJsonData);


        }

        public static void SerializeBanners(List<Banner> banners, string path = "SerialJson\\Banners.json")
        {

            string deportesJsonData = JsonSerializer.Serialize(banners);
            File.WriteAllText(path, deportesJsonData);


        }

        //deserealizacion//

        public static string GetJson(string filepath)
        {

            string jsonFile;
            using (var reader = new StreamReader(filepath))
            {
                jsonFile = reader.ReadToEnd();
            }
            return jsonFile;

        }


        public static List<Usuario> DeserializeUsuarios(String jsonFile)
        {

            var usuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonFile);
            return usuarios;

        }

        public static List<Banner> DeserializeBanners(String jsonFile)
        {

            var Banners = JsonSerializer.Deserialize<List<Banner>>(jsonFile);
            return Banners;



        }

        public static List<Deporte> DeserializeDeportes(String jsonFile)
        {

            var deportes = JsonSerializer.Deserialize<List<Deporte>>(jsonFile);
            return deportes;

        }
        public static void DeserializeFile(String jsonFile)
        {

            var file = JsonSerializer.Deserialize<String[]>(jsonFile);

        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public static List<Deporte> GetDeporte(int a, string constraint) {

            List<Deporte> deportes = new List<Deporte>();

            switch (a) {

                case 1:

                    deportes = cbd.SelectDeportes($"SELECT * FROM Deporte WHERE NomDeporte = '{constraint}'");

                    break;

            } return deportes;
        }

        //para terminar 
        public static List<Usuario> GetUsuarios(int a, string constraint)
        {


            List<Usuario> usuarios = null;


            switch (a)
            {

                case 1:


                    usuarios = cbd.SelectUsuarios("SELECT * FROM Usuario");
                    break;

                case 2:

                    usuarios = cbd.SelectUsuarios("");  

                        break;


            }

        }

        public static List<Encuentro> GetEncuentros(int a, s) { }


        public static List<Banner> GetBanner(int a, string constraint) {

            List<Banner> banners = new List<Banner>();

            switch (a)
            {
                case 1:

                    banners = cbd.SelectBanner("SELECT * FROM  Publicidad");
                    break;

                case 2:
                    banners = cbd.SelectBanner($"SELECT * FROM Publicidad WHERE ID_Publicidad = '{constraint}' OR " + $"Titulo_Publicidad");
                    break;

                case 3:
                    banners = cbd.SelectBanner($"SELECT * FROM Publicidad  WHERE  ID_Publicidad = '{constraint}'");
                    break;





            } return banners;





        }

        public static List<Deportista> GetDeportista(int a, string constraint) {

            List<Deportista> deportistas = null;
            switch (a) {

                case 1:

                    
                    deportistas = cbd.SelectDeportista("SELECT * FROM Deportista");

                  break;

                case 2:

                    deportistas = cbd.SelectDeportista($"SELECT * FROM Deportista WHERE ID_Persona = '{constraint}' OR CONCAT(Nombre, ' ' , Apellido ) LIKE '%{constraint}%' OR Nacionalidad LIKE '%{constraint}'");

                    break;

                case 3:

                    deportistas = cbd.SelectDeportista($"SELECT * FROM Deportista WHERE ID_Persona =  '{constraint}'");
                    

                    break;





                   


            }



        }

        public static void InsertBanner(string Titulo_Banner, string Link_Banner, string banner) {

            cbd.EjecutarSQL














        }


        // public static List<Deporte>









        public static void Borrar(string table, string clave, string data) {

            cbd.EjecutarSQL($"DELETE FROM {table} WHERE {clave} = '{data}' ");



        }


        public static int VerificarSiExiste(string table, string clave, string data) {

            int Verif = cbd.CheckSiExiste($"SELECT COUNT(+)FROM{table}WHERE {clave} = '{data}'");

        }



        public static void InsertarUsuario(string Nom_Usuario, string mail, string password, string nivelPermiso) {



            cbd.($"INSERT INTO Usuario(Nom_Usuario, mail, Contrasena, nivelPermiso) VALUES({Nom_Usuario}, {mail}, {password}, {nivelPermiso})");




        }

        public static void InsertarPersona(string nom, string ape, string pais) {


            cbd.EjecutarSQL($"INSERT INTO Persona(Nombre, Apellido, Nacionalidad) VALUES ({nom}, {ape}, {pais}) ");


        }








        public static void InsertarEncuentro(string Nom_encuentro, string Nom_Deporte, string nomArbitro, string HoraInicio, string Lugar, string Fecha) {

            Deporte x = GetDeporte(3, Nom_Deporte)[0];

            int ID_Deporte = x.ID_Deporte;

            int ID_Categoria = GetCategoria(3, x.Nom_Categoria)[0].ID_Categoria;

            int ID_Persona = GetPersona(1, Nom_Arbitro)[0].ID_Persona;

            cbd.EjecutarSQL($"INSERT INTO Encuentro (Nom_Encuentro, ID_Deporte, ID_Categoria, ID_Persona , HoraInicio, Lugar, Fecha) VALUES ({Nom_encuentro}, {ID_Deporte}, {ID_Categoria}, {ID_Persona}, {HoraInicio}, '{Lugar}', '{Fecha}',)")




        }


        public static void InsertarPuntuacion(int ID_Encuentro, int Puntos, int ID_Equipo) {


            cbd.EjecutarSQL($"INSERT INTO  PuntosEncuentro(ID_Encuentro, Puntos, ID_Equipo) VALUES ({ID_Encuentro}, {Puntos}, {ID_Encuentro})");




        }

        public static void InsertarDeportista(string Nom_Deportista, string Ape_Deportista, string Nacionalidad) {


            int ID_Persona = GetPersona(1, Nom_Deportista + " " + Ape_Deportista)[0].ID_Persona;

            cbd.EjecutarSQL($"INSERT INTO Deportista(ID_Persona, Nom_Deportista, Ape_Deportista, Nacionalidad) VALUES ({ID_Persona}, {Nom_Deportista}, {Ape_Deportista}, {Nacionalidad})");




        }























    }
}
