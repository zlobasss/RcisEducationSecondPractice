using Npgsql;

namespace PracticWork5

{
    /// <summary>
    /// Класс DatabaseService
    /// отвечает за подключение и открытие соединения с БД 
    /// </summary>
    public static class DatabaseService
    {
        /// <summary>
        /// Переменная _connection
        /// хранит открытое соединение с БД
        /// </summary>
        private static NpgsqlConnection? _connection;
        /// <summary>
        /// Метод GetConnectionString()
        /// возвращает строку подключения к БД
        /// </summary>
        private static string GetConnectionString()
        {
            return @"Host=10.30.0.137;Port=5432;Database=gr612_zlsse;Username=gr612_zlsse;Password=*****";
        }

        /// <summary>
        /// Метод GetSqlConnection()
        /// проверяет есть ли уже открытое соединение с БД
        /// если нет, то открывает соединение с БД
        /// </summary>
        /// <returns></returns>
        public static NpgsqlConnection GetSqlConnection()
        {
            if (_connection is null)
            {
                _connection = new NpgsqlConnection(GetConnectionString());
                _connection.Open();
            }
            
            return _connection;
        }
    }
}