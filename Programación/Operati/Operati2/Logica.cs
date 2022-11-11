using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Operati2;
using System.Security.Cryptography;

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
        }  //hecho

        
        public static List<Usuario> GetUsuarios(int a, string constraint, string constraint2, string constraint3)
        {


            List<Usuario> usuarios = null;


            switch (a)
            {

                case 1:


                    usuarios = cbd.SelectUsuarios("SELECT * FROM Usuario");
                    break;

                case 2:
                                                                                                                                                                
                    usuarios = cbd.SelectUsuarios($"SELECT * FROM Usuario WHERE Mail = '{constraint}' AND Nom_Usuario = '{constraint2}' AND Contraseña = '{constraint3}'");  

                        break;


            }return usuarios;

        } // hecho

        public static List<Equipo> GetEquipos(int a, string constraint) {

            List<Equipo> equipos = null;

            switch (a) {

                case 1:

                    equipos = cbd.SelectEquipos("SELECT * FROM Equipo");

                    break;

                case 2:

                    equipos = cbd.SelectEquipos($"SELECT * FROM  Equipo WHERE ID_Equipo = {constraint} OR  Nom_Equipo LIKE '%{constraint}%' OR Pais_Origen LIKE '%{constraint}%'");

                    break;

                    case 3:

                    equipos = cbd.SelectEquipos($"SELECT * FROM Equipo WHERE Nom_Equipo = '{constraint}'");

                    break;

                case 4:

                    equipos = cbd.SelectEquipos($"SELECT * FROM Equipo WHERE ID_Equipo = {constraint}");

                    break;








            }return equipos;









        }

        public static List<Evento> GetEventos(int a , string constraint) {

            List<Evento> eventos = null;

            switch (a) {

                case 1:

                    eventos = cbd.SelectEventos("SELECT * FROM Evento");

                    break;
                case 2:

                    eventos = cbd.SelectEventos($"SELECT * FROM  Evento WHERE ID_Evento = {constraint}");

                    break;
                case 3:

                    eventos = cbd.SelectEventos($"SELECT * FROM Evento WHERE Nom_Evento = '{constraint}'");

                    break;
                case 4:

                    eventos = cbd.SelectEventos($"SELECT * FROM Evento WHERE ID_Evento = {constraint} OR Nom_Evento LIKE '{constraint}'");

                    break;









            }return eventos;


        } // hecho

        public List<PuntuacionRound> GetPuntuaciones(int a, int constraint1, int constraint2, int constraint3)
        {
            List<PuntuacionRound> puntuacionRounds = null;

            switch (a) {

                case 1:
                    puntuacionRounds = cbd.SelectPuntuacionRound($"SELECT * FROM PuntajeRound WHERE ID_Encuentro = '{constraint1}' AND ID_Equipo = '{constraint2}' AND Puntua = '{constraint3}'");
                    break;



            }return puntuacionRounds;


        }          

        public static List<Persona> GetPersonas(int a, string constraint) {

            List<Persona> personas = null;
            switch (a) {

                case 1:
                    personas = cbd.SelectPersona($"SELECT * FROM Persona WHERE CONCAT (Nom_Persona ' ' Ape_Persona) = '{constraint}'");
                    break;





            } return personas;


        } // hecho

        public static List<Arbitro> GetArbitros(int a, string constraint) {

            List<Arbitro> arbitros = null;

            switch (a) {

                case 1:

                    arbitros = cbd.SelectArbitros($"SELECT * FROM Arbitro ");

                    break;
                case 2:

                    arbitros = cbd.SelectArbitros($"SELECT * FROM Arbitro WHERE ID_Persona =  '{constraint}' OR CONCAT(Nombre, ' ' ,Apellido) LIKE '%{constraint}%' OR Nacionalidad LIKE '%{constraint}%'");

                    break;
                case 3:

                    arbitros = cbd.SelectArbitros($"SELECT * FROM Arbitro WHERE ID_Persona = '{constraint}'");

                    break;




            }

            return arbitros;







        }  //hecho

        public static List<Encuentro> GetEncuentros(int a, string constraint) {

            List<Encuentro> encuentros = null;

            switch (a) {

                case 1:
                    encuentros = cbd.SelectEncuentros($"SELECT * FROM Encuentro");
                    break;
                case 2:
                    encuentros = cbd.SelectEncuentros($"SELECT * FROM  Encuentro WHERE ID_Encuentro = '{constraint}' OR Nom_Encuentro LIKE '%{constraint}%' ");
                    break;
                case 3:
                    encuentros = cbd.SelectEncuentros($"SELECT * FROM Encuentro WHERE Nom_Encuentro = '{constraint}'");
               
                    break;
                case 4:
                    encuentros = cbd.SelectEncuentros($"SELCT * FROM Encuentro WHERE ID_Encuentro  = '{constraint}'");
                    break;






            }return encuentros;

        }


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


        } //hecho

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




            }return deportistas;



        } //hecho


        









        public static void InsertBanner(string Titulo_Banner, string Link_Banner, string banner) {

            cbd.EjecutarSQL($"INSERT INTO Publicidad (Titulo_Banner, Link_Banner, Imagen_Banner) VALUES '{Titulo_Banner}', '{Link_Banner}', '{banner}'");

        } //hecho


        // public static List<Deporte>


        public static void Borrar(string table, string clave, string data) {

            cbd.EjecutarSQL($"DELETE FROM {table} WHERE {clave} = '{data}' ");



        } //hecho

        public static int VerificarSiExiste(string table, string clave, string data) {

            int Verif = cbd.CheckSiExiste($"SELECT COUNT(+)FROM '{table}' WHERE '{clave}' = '{data}'");
            return Verif;

        }  //hecho

        public static void InsertarUsuario(string Nom_Usuario, string mail, string password, int nivelPermiso) {



            cbd.EjecutarSQL($"INSERT INTO Usuario(Nom_Usuario, Mail, password, nivelPermiso) VALUES('{Nom_Usuario}', '{mail}', '{password}', {nivelPermiso})");




        }  //hecho

        public static void InsertarPersona(string nom, string ape, string pais) {


            cbd.EjecutarSQL($"INSERT INTO Persona(Nom_Persona, Ape_Persona, Nacionalidad) VALUES ('{nom}', '{ape}', '{pais}') ");


        }  //hecho 

        public static void InsertarCategoria(string nomcategoria) {

            cbd.EjecutarSQL($"INSERT INTO Categoria (Nom_Categoria) VALUES ('{nomcategoria}')");

        }  //hecho

        public static void InsertarDeporte(string nomdepor) {

            cbd.EjecutarSQL($"INSERT INTO Deporte (Nom_Deporte) VALUES ({nomdepor})"); 


        }  //hecho










        public static void InsertarEncuentro(string Nom_encuentro, string Nom_Deporte, string nomArbitro, string HoraInicio, string Lugar, string Fecha) {

            Deporte x = GetDeporte(3, Nom_Deporte)[0];

            int ID_Deporte = x.ID_Deporte;

            int ID_Categoria = GetCategoria(3, x.Nom_Categoria)[0].ID_Categoria;

            int ID_Persona = GetPersonas(1, Nom_Arbitro)[0].ID_Persona;

            cbd.EjecutarSQL($"INSERT INTO Encuentro (Nom_Encuentro, ID_Deporte, ID_Categoria, ID_Persona , HoraInicio, Lugar, Fecha) VALUES ('{Nom_encuentro}', {ID_Deporte}, {ID_Categoria}, {ID_Persona}, '{HoraInicio}', '{Lugar}', '{Fecha}',)");




        }


        public static void InsertarPuntuacion(int ID_Encuentro, int Puntos, int ID_Equipo) {


            cbd.EjecutarSQL($"INSERT INTO  PuntosEncuentro(ID_Encuentro, Puntos, ID_Equipo) VALUES ({ID_Encuentro}, {Puntos}, {ID_Encuentro})");




        }

        public static void InsertarDeportista(string Nom_Deportista, string Ape_Deportista, string Nacionalidad) {


            int ID_Persona = GetPersonas(1, Nom_Deportista + " " + Ape_Deportista)[0].ID_Persona;

            cbd.EjecutarSQL($"INSERT INTO Deportista(ID_Persona, Nom_Deportista, Ape_Deportista, Nacionalidad) VALUES ({ID_Persona}, '{Nom_Deportista}', '{Ape_Deportista}', '{Nacionalidad}')");




        }

        public static void InsertarEquipo(string nom, string origen) {

            cbd.EjecutarSQL($"INSERT INTO Equipo(Nom_Equipo, Pais_Origen) VALUES ('{nom}', '{origen}')");



        } 

        public static void InsertarArbitro(string nom, string ape, string nacionalidad) {

            int ID_Persona = GetPersonas(1, nom + " " + ape)[0].ID_Persona;

            cbd.EjecutarSQL($"INSERT INTO Arbitro (ID_Persona, Nom_Arbitro, Ape_Arbitro, Nacionalidad) VALUES ({ID_Persona}, '{nom}', '{ape}', '{nacionalidad}')");


        }



  
        
        
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
        //howtoEncript

        public static TripleDES DesencriptarCl (string clave) {

            MD5 md5 = new MD5CryptoServiceProvider(); // provider q nos da un servicio facil para encriptar
            TripleDES tripleDES = new TripleDESCryptoServiceProvider();

            tripleDES.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(clave));

            tripleDES.IV = new byte[tripleDES.BlockSize / 0];

            return tripleDES;
        }

        public static string EncriptamosContra(string txtA, string password)
        {

            byte[] txtABytes = Encoding.Unicode.GetBytes(txtA);

            MemoryStream memoryFlow = new MemoryStream();

            //using System.Security.Cryptography;  Realiza el cifrado y descifrado simétricos mediante la implementación de interfaces de programación de aplicaciones criptográficas .

            TripleDES tripleDES = DesencriptarCl(password);



            CryptoStream EncriptFlow = new CryptoStream(memoryFlow, tripleDES.CreateEncryptor(), CryptoStreamMode.Write); // creamos el encriptador


            EncriptFlow.Write(txtABytes, 0, txtABytes.Length);
            EncriptFlow.FlushFinalBlock();

            return Convert.ToBase64String(memoryFlow.ToArray());
        }

        public static string DesencriptamosContra(string txtYaEncriptado, string password) {

            byte[] txtyaEncriptadoByte = Convert.FromBase64String(txtYaEncriptado);
            MemoryStream memoryFlow = new MemoryStream();
            TripleDES tripleDES = DesencriptarCl(password);


            CryptoStream DesencriptFlow = new CryptoStream(memoryFlow, tripleDES.CreateDecryptor(), CryptoStreamMode.Write); // creamos el desencriptador


            DesencriptFlow.Write(txtyaEncriptadoByte, 0, txtyaEncriptadoByte.Length);
            DesencriptFlow.FlushFinalBlock();

            return Encoding.Unicode.GetString(memoryFlow.ToArray());
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////








    }
}
