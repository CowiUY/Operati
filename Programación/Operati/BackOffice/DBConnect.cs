using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Add MySql Library
using MySql.Data.MySqlClient;


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
            Initialize();
        }

        //inicializar valores
        private void Initialize()
        {
            server = "localhost";
            database = "connectcsharptomysql";
            uid = "username";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to database
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
            string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
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

            //Create a list to store the result
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
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
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
                MessageBox.Show("Error , unable to backup!");
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
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}

