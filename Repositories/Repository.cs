using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)

            => _connection = connection;
        
        public IEnumerable<T> Get()
           => _connection.GetAll<T>();

        public T Get(int id)

            => _connection.Get<T>(id);

        public void Insert(T t)

           => _connection.Insert<T>(t);

        public void Update(T t)

            => _connection.Update<T>(t);

        public void Delete(int id)
        {
            var t = _connection.Get<T>(id);
            _connection.Delete<T>(t);
        }
    }
}