using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;
using System.Data.Common;

namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public static class Db
    {
        private static readonly string connectionString = "";
        private static readonly string bancoEscolhido = "";

        static Db()
        {
            bancoEscolhido = ConfigurationManager.AppSettings["bancodedados"].ToLower().Trim();
            connectionString = ConfigurationManager.ConnectionStrings[bancoEscolhido].ConnectionString;
        }

        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            try
            {
                if (bancoEscolhido.Equals("dbsqlite"))
                    return InsertSQLite(sql, parameters);
                else if (bancoEscolhido.Equals("dbsqlserver"))
                    return InsertSQL(sql, parameters);
                return 0;
            }
            catch (NullReferenceException e)
            {
                Console.Write(e.Message);
                //Console.Read();
                return -1;
            }
            
        }

        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {
            if (bancoEscolhido.Equals("dbsqlite"))
                UpdateSQLite(sql, parameters);
            else if (bancoEscolhido.Equals("dbsqlserver"))
                UpdateSQL(sql, parameters);
        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            if (bancoEscolhido.Equals("dbsqlite"))
                UpdateSQLite(sql, parameters);
            else if (bancoEscolhido.Equals("dbsqlserver"))
                UpdateSQL(sql, parameters);
        }

        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            if (bancoEscolhido.Equals("dbsqlite"))
                return GetAllSQLite(sql, convert, parameters);
            else if (bancoEscolhido.Equals("dbsqlserver"))
                return GetAllSQL(sql, convert, parameters);
            return null;
        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            if (bancoEscolhido.Equals("dbsqlite"))
                return GetSQLite(sql, convert, parameters);
            else if (bancoEscolhido.Equals("dbsqlserver"))
                return GetSQL(sql, convert, parameters);
            return default(T);
        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            if (bancoEscolhido.Equals("dbsqlite"))
                return ExistsSQLite(sql, parameters);
            else if (bancoEscolhido.Equals("dbsqlserver"))
                return ExistsSQL(sql, parameters);
            return false;
        }

        private static string AppendSelectIdentity(this string sql)
        {
            if (bancoEscolhido.Equals("dbsqlite"))
                return AppendSelectIdentitySQLite(sql);
            else if (bancoEscolhido.Equals("dbsqlserver"))
                return AppendSelectIdentitySQL(sql);
            return "";
        }

        private static bool IsNullOrEmpty(this object value)
        {
            return (value is string && string.IsNullOrEmpty((string)value)) ||
                    value == null;
        }

        //SQL

        public static int InsertSQL(string sql, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql.AppendSelectIdentity(), connection);

            command.SetParametersSQL(parameters);

            connection.Open();

            int id = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return id;
        }

        public static void UpdateSQL(string sql, Dictionary<string, object> parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

            command.SetParametersSQL(parameters);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void DeleteSQL(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        public static List<T> GetAllSQL<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

            command.SetParametersSQL(parameters);

            connection.Open();

            var list = new List<T>();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var obj = convert(reader);
                    list.Add(obj);
                }
            }
            connection.Close();
            return list;
        }

        public static T GetSQL<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

            command.SetParametersSQL(parameters);

            connection.Open();

            T t = default;

            using (var reader = command.ExecuteReader())
            { 
                if (reader.Read())
                    t = convert(reader);
            }
            connection.Close();
            return t;
        }

        public static bool ExistsSQL(string sql, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sql, connection);

            command.SetParametersSQL(parameters);

            connection.Open();

            int numberRows = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return numberRows > 0;
        }

        private static void SetParametersSQL(this SqlCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                SqlParameter dbParameter = new SqlParameter(name, value);

                command.Parameters.Add(dbParameter);
            }
        }

        private static string AppendSelectIdentitySQL(this string sql)
        {
            return sql + ";SELECT SCOPE_IDENTITY()";
        }

        //SQLite

        public static int InsertSQLite(string sql, Dictionary<string, object> parameters)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(sql.AppendSelectIdentitySQLite(), connection);
            command.SetParametersSQLite(parameters);

            int id = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return id;
        }

        public static void UpdateSQLite(string sql, Dictionary<string, object> parameters = null)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            SQLiteCommand command = new SQLiteCommand(sql, connection);

            command.SetParametersSQLite(parameters);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void DeleteSQLite(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        public static List<T> GetAllSQLite<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            SQLiteCommand command = new SQLiteCommand(sql, connection);

            command.SetParametersSQLite(parameters);

            connection.Open();

            var list = new List<T>();

            using (var reader = command.ExecuteReader())
            { 
                while (reader.Read())
                {
                    var obj = convert(reader);
                    list.Add(obj);
                }
            }
            connection.Close();
            return list;
        }

        public static T GetSQLite<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            SQLiteCommand command = new SQLiteCommand(sql, connection);

            command.CreateParameter();
            command.SetParametersSQLite(parameters);

            connection.Open();

            T t = default;

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                    t = convert(reader);
            }
            connection.Close();
            return t;
        }

        public static bool ExistsSQLite(string sql, Dictionary<string, object> parameters)
        {
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            SQLiteCommand command = new SQLiteCommand(sql, connection);

            command.SetParametersSQLite(parameters);

            connection.Open();

            int numberRows = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return numberRows > 0;
        }

        public static void SetParametersSQLite(this SQLiteCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                string name = parameter.Key;

                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;

                SQLiteParameter dbParameter = new SQLiteParameter(name, value);

                command.Parameters.Add(dbParameter);
            }
        }

        private static string AppendSelectIdentitySQLite(this string sql)
        {
            return sql + ";SELECT last_insert_rowid()";
        }
    }
}
