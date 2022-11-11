using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackOffice;


//Añadir MySql Library
using MySql.Data.MySqlClient;


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// '''''''''''''''''''''''''''''''''''



namespace BackOffice
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

       

        //Constructor
        public DBConnect()
        {
           
            InitializeDB();
        }

        //inicializar valores
        private void InitializeDB()
        {
            try
            {
                server = "192.168.5.50";
                database = "gabriel_moreira";
                uid = "gabriel.moreira";
                password = "54748096";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "Pwd=" + password + ";";

                connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Abre conexion a la base
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //si se tiene errores,hacemos que la app responda a base de estos errores.
                //numeros de error cuando te conectas al server:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("NO se puede conectar al server , contacte al administrador");
                        break;

                    case 1045:
                        MessageBox.Show("usuario o contraseña invalidos , por favor intente de nuevo");
                        break;
                }
                return false;
            }
        }

        //Cierra conexion
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Inserta la declaracion
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name, age) VALUES('Pepe', '20')";

            //Abrimos conexion
            if (this.OpenConnection() == true)
            {
                //crea el comando y asigna cola y la conexion del constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Ejecuta comando
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Actualiza declaracion
        public void Update()
        {
            string query = "UPDATE tableinfo SET name=' alfonso ', age='22' WHERE name='pepe'";

            //Abre la conexion
            if (this.OpenConnection() == true)
            {
                //crea comando mysql
                MySqlCommand cmd = new MySqlCommand();
                //Asigna la consulta usando CommandText
                cmd.CommandText = query;
                //Asigna la connexion usando Connection
                cmd.Connection = connection;

                //Ejecuta la consulta
                cmd.ExecuteNonQuery();

                //cierra la conexion
                this.CloseConnection();
            }
        }

        //Borra la declaracion
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='pepe'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Selecciona la declaracion
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //crea una lsita para guardar el resultado
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Abre la conexion
            if (this.OpenConnection() == true)
            {
                //crea el comando 
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //crea un data reader y ejecuta el comando
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //lee los datos y los guarda
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["nombre"] + "");
                    list[2].Add(dataReader["edad"] + "");
                }

                //cierra el datareader
                dataReader.Close();

                //cierra conexion
                this.CloseConnection();

                //retorna para ser mostrado
                return list;
            }
            else
            {
                return list;
            }
        }

        //Contar
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;


            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);

                Count = int.Parse(cmd.ExecuteScalar() + "");


                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Respaldo
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //guarda el archivo a C:\ con la fecha como nombre
                string path;
                path = "C:\\" + year + "-" + month + "-" + day + "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("ERROR, no se puede hacer backup!");
            }
        }

        //Checkea si existe
        public int CheckSiExiste(string query)
        {

            int resultado = 1;

            try {
                if (OpenConnection() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    resultado = Convert.ToInt32((Int64)cmd.ExecuteScalar());

                    CloseConnection();
                    return resultado;


                }
                else {

                    CloseConnection();
                    return resultado;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                CloseConnection();
                return 1;
            }

        }

        //Restaurar
        public void Restore()
        {
            try
            {
                //Lee el archivo de C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("ERROR, no se puede restaurar!");
            }
        }


        public List<Usuario> SelectUsuarios(string query){

            List<Usuario> usuarios = new List<Usuario>();

            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Usuario usuario = new Usuario();

                    usuario.ID_Usuario = Convert.ToInt16($"{dataReader.GetString("ID_Usuario")}");

                    usuario.Mail = $"{dataReader.GetString("Mail")}";

                    usuario.Nom_Usuario = $"{dataReader.GetString("Nom_Usuario")}";

                    usuario.password = $"{dataReader.GetString("password")}";

                    usuario.nivelPermiso = Convert.ToInt16($"{dataReader.GetString("nivelPermiso")}");

                    usuarios.Add(usuario);

                }

                dataReader.Close();
                CloseConnection();

                return usuarios;


            }
            else {
                CloseConnection();
                return usuarios;




            }

        }                    //hecho

        public List<Equipo> SelectEquipos(string query) {

            List<Equipo> equipos = new List<Equipo>();

            try {


                if (OpenConnection() == true) {

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read()) {


                        Equipo equipo = new Equipo();

                        equipo.ID_Equipo = Convert.ToInt16($"{dataReader.GetString("ID_Equipo")}");

                        equipo.Nom_Equipo = $"{dataReader.GetString("Nom_Equipo") }";

                        equipo.Pais_Origen = $"{dataReader.GetString("Pais_Origen")}";


                        equipos.Add(equipo);


                    }

                    dataReader.Close();
                    CloseConnection();


                    return equipos;


                }
                else {


                    CloseConnection();
                    return equipos;

                }



            } catch { return equipos; }


        }                     //hecho
        
        public List<Banner> SelectBanner(string query) {

            List<Banner> banners = new List<Banner>();



            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Banner banner = new Banner();

                    try {


                        banner.ID_Banner = Convert.ToInt32($"{dataReader.GetString("IdPublicidad")}");


                        banner.Imagen_Banner = $"{dataReader.GetString("Imagen_Banner")}";

                        banner.Link_Banner = $"{dataReader.GetString("LinkBanner")}";

                        banner.Titulo_Banner = $"{dataReader.GetString("TituloBanner")}";






                    } catch { }

                               

                    banners.Add(banner);
                }

                dataReader.Close();
                CloseConnection();

                return banners;
            }
            else {

                CloseConnection();
                return banners;


            }
        }                      //hecho

        public List<Persona> SelectPersona(string query) {

            List<Persona> personas = new List<Persona>();


            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Persona persona = new Persona();

                    persona.ID_Persona = Convert.ToInt16($"{dataReader.GetString("ID_Persona")}");

                    persona.Nom_Persona = $"{dataReader.GetString("Nom_Persona")}";

                    persona.Ape_Persona = $"{dataReader.GetString("Ape_Persona")}";

                    persona.Nacionalidad = $"{dataReader.GetString("Nacionalidad")}";

                    personas.Add(persona);

                }

                dataReader.Close();
                CloseConnection();

                return personas;


            }
            else
            {
                CloseConnection();
                return personas;
            }







        }                    //hecho

        public List<Encuentro> SelectEncuentro(string query) {

            List<Encuentro> encuentros = new List<Encuentro>(); 

            if (OpenConnection() == true) {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read()) {

                    Encuentro encuentro = new Encuentro();

                    encuentro.ID_Encuentro = Convert.ToInt16($"{dataReader.GetString("ID_Encuentro")}");

                    encuentro.ID_Persona = Convert.ToInt16($"{dataReader.GetString("ID_Persona")}");

                    encuentro.ID_Categoria = Convert.ToInt16($"{dataReader.GetString("ID_Categoria")}");

                    encuentro.ID_Deporte = Convert.ToInt16($"{dataReader.GetString("ID_Deporte")}");

                    encuentro.Hora = $"{dataReader.GetString("Hora")}";

                    encuentro.Fecha = $"{dataReader.GetString("Fecha")}";

                    encuentro.Nom_Encuentro = $"{dataReader.GetString("Nom_Encuentro")}";

                    encuentros.Add(encuentro);

                }

                dataReader.Close();
                CloseConnection();

                return encuentros;



            } else {

                CloseConnection();

                return encuentros;

            }
        }

        public List<Evento> SelectEventos(string query)
        {

            List<Evento> eventos = new List<Evento>();

            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Evento evento = new Evento();

                    try
                    {



                        evento.ID_Evento = Convert.ToInt16($"{dataReader.GetString("ID_Evento")}");

                        evento.Nom_Evento = $"{dataReader.GetString("Nom_Evento")}";

                        evento.Lugar_Evento = $"{dataReader.GetString("Lugar_Evento")}";

                        evento.Fecha_Evento = $"{dataReader.GetString("Fecha_Evento")}";

                        evento.Hora_Evento = $"{dataReader.GetString("Hora_Evento")}";


                    }
                    catch { }

                    eventos.Add(evento);

                }

                dataReader.Close();
                CloseConnection();

                return eventos;







            }
            else {

                CloseConnection();
                return eventos;

            }










        }                      //hecho
         
        public List<Deporte> SelectDeportes(string query) {


            List<Deporte> deportes = new List<Deporte>();

            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Deporte deporte = new Deporte();

                    deporte.ID_Deporte = Convert.ToInt32($"{dataReader.GetString("ID_Deporte")}"); // hecho

                    deporte.Categoria_Deporte = $"{dataReader.GetString("Categoria")}";


                    deporte.Nom_Deporte = $"{dataReader.GetString("Nom_Deporte")}";

                    deportes.Add(deporte);


                }

                dataReader.Close();
                CloseConnection();

                return deportes;


            }
            else {

                CloseConnection();
                return deportes; 
            }







        }                   //hecho

        public List<Arbitro> SelectArbitros(string query) {

            List<Arbitro> arbitros = new List<Arbitro>();

            if (OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Arbitro arbitro = new Arbitro();


                    arbitro.ID_Persona = Convert.ToInt16($"{dataReader.GetString("ID_Persona")}");

                    arbitro.Nom_Arbitro = $"{dataReader.GetString("Nom_Arbitro")}";

                    arbitro.Ape_Arbitro = $"{dataReader.GetString("Ape_Arbitro")}";

                    arbitro.Nacionalidad = $"{dataReader.GetString("Nacioalidad")}";




                    arbitros.Add(arbitro);


                }

                dataReader.Close();
                CloseConnection();

                return arbitros;

            }
            else
            {

                CloseConnection();
                return arbitros;

            }


        }                   // hecho
        
        public List<Deportista> SelectDeportista(string query) {

            List<Deportista> deportistas = new List<Deportista>();


            if (OpenConnection() == true)
            {


                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    Deportista deportista = new Deportista();

                    deportista.ID_Deportista = Convert.ToInt32($"{dataReader.GetString("ID_Deportista")}");

                    deportista.Nom_Deportista = $"{dataReader.GetString("Nom_Deportista")}";

                    deportista.Ape_Deportista = $"{dataReader.GetString("Ape_Deportista")}";

                    deportista.Nacionalidad = $"{dataReader.GetString("Nacionalidad")}";



                    deportistas.Add(deportista);



                }

                dataReader.Close();
                CloseConnection();

                return deportistas;

            }
            else {

                CloseConnection();
                return deportistas;

            }

        }              //hecho

        public List<Categoria> SelectCategorias(string query) {


            List<Categoria> categorias = new List<Categoria>();

            if (OpenConnection() == true)
            {


                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    Categoria categoria = new Categoria();

                    categoria.ID_Categoria = Convert.ToInt32($"{dataReader.GetString("ID_Categoria")}");

                    categoria.Nom_Categoria = $"{dataReader.GetString("Nom_Categoria")}";

                    categorias.Add(categoria);





                }


                dataReader.Close();
                CloseConnection();
                return categorias;




            }
            else {

                CloseConnection();

                return categorias;

            }


        }               //hecho

        public List<EncuentrosEquipo> SelectEncuentrosEquipo(string query) {

            List<EncuentrosEquipo> encuentrosEquipos = new List<EncuentrosEquipo>();

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    try {

                        EncuentrosEquipo encuentroEquipo = new EncuentrosEquipo();

                        encuentroEquipo.ID_Encuentro = Convert.ToInt16($"{dataReader.GetString("ID_Encuentro")}");

                        encuentroEquipo.ID_Categoria = Convert.ToInt16($"{dataReader.GetString("ID_Categoria")}");

                        encuentroEquipo.ID_Deporte = Convert.ToInt16($"{dataReader.GetString("ID_Deporte")}");

                        encuentroEquipo.ID_Equipo = Convert.ToInt16($"{dataReader.GetString("ID_Equipo")}");

                        encuentroEquipo.ID_Persona = Convert.ToInt16($"{dataReader.GetString("ID_Persona")}");

                        encuentroEquipo.Puntuacion = Convert.ToInt16($"{dataReader.GetString("Puntuacion")}");

                        encuentroEquipo.Nom_Equipo = $"{dataReader.GetString("Nom_Equipo")}";

                        encuentroEquipo.Nom_Encuentro = $"{dataReader.GetString("Nom_Encuentro")}";

                        encuentroEquipo.Fecha = $"{dataReader.GetString("Fecha")}";

                        encuentroEquipo.Hora = $"{dataReader.GetString("Hora")}";

                        encuentroEquipo.Lugar = $"{dataReader.GetString("Lugar")}";

                    } catch { }



                }

                CloseConnection();
                dataReader.Close();

                return encuentrosEquipos;







            }
            else {

                CloseConnection();

                return encuentrosEquipos;


            }

        








        }  //hecho

        public int ComprobarExistencia(string query) {

            int resultado = 1;

            try
            {

                if (OpenConnection() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    resultado = Convert.ToInt32((Int64)cmd.ExecuteScalar());

                    CloseConnection();
                    return resultado;




                }
                else
                {

                    CloseConnection();
                    return resultado;



                }




            }
            catch (Exception ex ){

                MessageBox.Show(ex.Message);
                CloseConnection();
                return 1;



            }

        }                        //hecho

        public void EjecutarSQL(string query) {
            try
            {
                if (OpenConnection() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    CloseConnection();

                    return;







                }
                else
                {

                    CloseConnection();

                    return;





                }

            }
            catch (MySqlException ex){

                MessageBox.Show("Error de MySQL");
                MessageBox.Show(ex.Message);

                CloseConnection(); // cerramos conexion

            }





        }                               //hecho













    }




}

