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
        //serializacion//

        public static void SerializeUsuarios(List<Usuario> usuarios, string path = "SerialJson\\Usuarios.json")
        {

            string usuariosJsonData = JsonSerializer.Serialize(usuarios);
            File.WriteAllText(path, usuariosJsonData);


        }

        public static void SerializeDeportes(List<Deporte> deportes, string path = "SerialJson\\Usuarios.json")
        {

            string deportesJsonData = JsonSerializer.Serialize(deportes);
            File.WriteAllText(path, deportesJsonData);


        }

        public static void SerializeBanners(List<Banner> banners, string path = "SerialJson\\Usuarios.jsonn")
        {

            string bannersJsonData = JsonSerializer.Serialize(banners);
            File.WriteAllText(path, bannersJsonData);

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

        public static List<Deporte> DeserializeDeportes(String jsonFile)
        {

            var deportes = JsonSerializer.Deserialize<List<Deporte>>(jsonFile);
            return deportes;

        }
        public static void DeserializeFile(String jsonFile)
        {

            var file = JsonSerializer.Deserialize<String[]>(jsonFile);

        }
    }
}
