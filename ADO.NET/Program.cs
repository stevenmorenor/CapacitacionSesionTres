using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParametersIN();
            //UtilizarUsing();
            //CrearConexion();

            Console.WriteLine("Presiones enter para continuar");
            Console.ReadLine();

        }
        #region conexion normal
        ////static void CrearConexion()
        ////{
        ////    string connString = "Data Source= DESKTOP-HDVJNKT\\SQLEXPRESS;" +
        ////                        "Initial Catalog= FormDb;" +
        ////                        "Integrated Security= true";



        ////    SqlConnection connection = new SqlConnection(connString);
        ////    connection.Open();

        ////    Console.WriteLine("Estado de la conexion: {0}", connection.State);
        ////    Console.Write("Presione enter para cerrar la conexion");
        ////    Console.ReadLine();

        ////    connection.Close();
        ////    connection.Dispose();

        ////    Console.WriteLine("Estado de la conexion: {0}", connection.State);
        ////}
        #endregion
        ////String builder para conexion a DB
        ////static void CrearConexion()
        ////{
        ////    SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
        ////    sb["Data Source"] = "DESKTOP-HDVJNKT\\SQLEXPRESS";
        ////    sb["Initial Catalog"] = "FormDb";
        ////    sb["Integrated Security"] = true;

        ////    string connString = sb.ConnectionString;



        ////    SqlConnection connection = new SqlConnection(connString);
        ////    connection.Open();

        ////    Console.WriteLine("Estado de la conexion: {0}", connection.State);
        ////    Console.Write("Presione enter para cerrar la conexion");
        ////    Console.ReadLine();

        ////    connection.Close();
        ////    connection.Dispose();

        ////    Console.WriteLine("Estado de la conexion: {0}", connection.State);
        ////}

        ////

        #region Conexion recomendada con Using
        //static void UtilizarUsing()
        //{
        //    string connString = "Data Source= DESKTOP-HDVJNKT\\SQLEXPRESS;" +
        //                        "Initial Catalog= FormDb;" +
        //                        "Integrated Security= true";

        //    SqlConnection connection;

        //    using(connection = new SqlConnection(connString))
        //    {
        //        connection.Open();

        //        Console.WriteLine("Estado de la conexion: {0}", connection.State);
        //        Console.Write("Presione enter para salir del using");
        //        Console.ReadLine();

        //    }
        //    Console.WriteLine("Estado de la conexion: {0}", connection.State);

            
        //}
        #endregion

        #region Consulta con multiples tablas
        ////static void UtilizarUsing() //Consulta con multiples tablas
        ////{
        ////    string connString = "Data Source= DESKTOP-HDVJNKT\\SQLEXPRESS;" +
        ////                        "Initial Catalog= futbolistas;" +
        ////                        "Integrated Security= true";

        ////    SqlConnection connection;

        ////    using (connection = new SqlConnection(connString))
        ////    {
        ////        connection.Open();

        ////        SqlCommand cmd = connection.CreateCommand();
        ////        cmd.CommandType = System.Data.CommandType.Text;
        ////        cmd.CommandText = "Select * from futbolistas; Select * from persona";

        ////        var reader = cmd.ExecuteReader();
        ////        do
        ////        {
        ////            while (reader.Read())
        ////            {
        ////                Console.WriteLine("{0},{1},{2}", reader[0], reader[1], reader[2]);
        ////            }
        ////        }while(reader.NextResult());


        ////        reader.Close();

        ////    }



        ////}
        #endregion

        ////static void UtilizarUsing() //Consulta con una tabla
        ////{
        ////    string connString = "Data Source= DESKTOP-HDVJNKT\\SQLEXPRESS;" +
        ////                        "Initial Catalog= futbolistas;" +
        ////                        "Integrated Security= true";

        ////    SqlConnection connection;

        ////    using (connection = new SqlConnection(connString))
        ////    {
        ////        //SqlCommand readcommand = new SqlCommand("Select * from [Id]", connection);
        ////        SqlCommand writecommand = new SqlCommand("Update Futbolistas Set Id = Id - @Id", connection);

        ////        connection.Open();

        ////        writecommand.Parameters.Add("@Id", SqlDbType.Int);

        ////        //SqlCommand cmd = connection.CreateCommand();
        ////        //cmd.CommandType = System.Data.CommandType.Text;
        ////        //cmd.CommandText = "Select Id, Nombre, Edad from futbolistas";

        ////        var reader = writecommand.ExecuteReader();
        ////        while (reader.Read())
        ////        {
        ////            //Console.WriteLine("{0},{1},{2}", reader[0], reader[1], reader[2]);
        ////            writecommand.Parameters["@Id"].Value = reader["Id"];
        ////            writecommand.ExecuteNonQuery();
        ////        }

        ////        reader.Close();
        ////        Console.WriteLine("Estado {0}", connection.State);
        ////        connection.Dispose();



        ////    }



        ////}
        #region Consulta con una tabla
        ////static void UtilizarUsing() //Consulta con una tabla
        ////{
        ////    string connString = "Data Source= DESKTOP-HDVJNKT\\SQLEXPRESS;" +
        ////                        "Initial Catalog= futbolistas;" +
        ////                        "Integrated Security= true";

        ////    SqlConnection connection;

        ////    using (connection = new SqlConnection(connString))
        ////    {
        ////        connection.Open();

        ////        SqlCommand cmd = connection.CreateCommand();
        ////        cmd.CommandType = System.Data.CommandType.Text;
        ////        cmd.CommandText = "Select Id, Nombre, Edad from futbolistas";

        ////        var reader = cmd.ExecuteReader();
        ////        while (reader.Read())
        ////        {
        ////            Console.WriteLine("{0},{1},{2}", reader[0],reader[1],reader[2]);
        ////        }

        ////        reader.Close();



        ////    }



        ////}
        #endregion

        #region Procedimiento almacenado
        //static void Main(string[] args)
        //{
        //    Proceso(2);


        //    Console.WriteLine("Presione enter");
        //    Console.ReadLine();

        //}

        //static void Proceso(int Id)
        //{
        //    SqlConnection connection = GetConnection();
        //    connection.Open();

        //    string name = "EliminarFutbolista";
        //    SqlCommand command = new SqlCommand(name, connection);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = Id;
        //    command.ExecuteNonQuery();


        //}

        //private static SqlConnection GetConnection()
        //{
        //    string cs = "Data Source = DESKTOP-HDVJNKT\\SQLEXPRESS;Initial Catalog =futbolistas;Integrated Security=true";

        //    return new SqlConnection(cs);
        //}



        #endregion

        #region Procedimiento almacenado 2
        //static void Proceso2(string nombre)
        //{
        //    Console.WriteLine("Segundo valor");
        //    SqlConnection connection2 = GetConnection();
        //    connection2.Open();

        //    string name2 = "Ordenar";
        //    SqlCommand command2 = new SqlCommand(name2, connection2);
        //    command2.CommandType = CommandType.StoredProcedure;
        //    command2.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = nombre;
        //    command2.ExecuteNonQuery();

        //}
        #endregion

        ////.ExecuteScalar va convertido en decimal 
        ////decimal scalar = (decimal)command.ExecuteScalar();
        ///


        static void ParametersIN() // Consulta usando parametro Input
        {
            SqlDataReader reader = null;
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = "Data Source =DESKTOP-HDVJNKT\\SQLEXPRESS;Initial Catalog=futbolistas;Integrated Security=true;";
                con.Open();

                string sql = "select Id, nombre, edad from futbolistas where edad > 40";
                SqlCommand command = new SqlCommand(sql, con);
                command.CommandType = CommandType.Text;

                //command.Parameters.AddWithValue("@min", 40);
                //command.Parameters.AddWithValue("@max", 100);

                reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}, {2}", reader["Id"], reader["nombre"],reader["edad"]);
                }

            }

        }

        static void ParameterIntOutReturn() // Consultas usando parametros Input, Ountput, Return
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=; Initial Catalog=futbolistas;Integrated Security=true;";
                connection.Open();

                string sql = "GetFutbolistas";

                SqlCommand command = new SqlCommand(sql,connection);
                command.CommandType = CommandType.StoredProcedure;

                var namePlayer = command.CreateParameter();
                namePlayer.ParameterName = "@Name";
                namePlayer.DbType = DbType.String;
                namePlayer.Size = 50;
                namePlayer.Direction = ParameterDirection.Output;
                command.Parameters.Add(namePlayer);

                int Id = 5;

                var agePlayer = command.CreateParameter();
                agePlayer.ParameterName = "@Age";
                agePlayer.DbType = DbType.Int32;
                agePlayer.Direction = ParameterDirection.Input;
                agePlayer.Value = Id;
                command.Parameters.Add(agePlayer);

                
                var returnValue = command.CreateParameter();
                returnValue.ParameterName = "@Team";
                returnValue.DbType = DbType.String;
                returnValue.Size = 50;
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);

                command.ExecuteNonQuery();
                if((int)returnValue.Value == Id)
                {
                    Console.WriteLine("{0},{1},{2}",agePlayer.Value, (decimal)agePlayer.Value,returnValue);

                }
                else
                {
                    Console.WriteLine("Resultado : {0}", returnValue.Value);    
                }

            }
        }
    }
     
}
