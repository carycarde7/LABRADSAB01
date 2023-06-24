using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LABRADSAB01.Controllers
{
    class DataBase
    {
        readonly SQLiteAsyncConnection _connection;

        public  DataBase() { }

        public DataBase(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            //creacion de objetos de base de datos
            _connection.CreateTableAsync<Models.Personas>().Wait();
        }

        //crear metodos CREATE READ UPDATE DELETE

        public Task<int> AddPersona(Models.Personas persona) 
        {
            if (persona.Id == 0)
            {
                return _connection.InsertAsync(persona);
            }
            else
            {
                return _connection.UpdateAsync(persona);
            }
        }

        public Task<List<Models.Personas>> GetPersonas()
        {
            return _connection.Table<Models.Personas>().ToListAsync();

        }    

        public Task<Models.Personas> GetPersonas(int pid) 
        {
            return _connection.Table<Models.Personas>().Where(i => i.Id == pid).FirstOrDefaultAsync();

        }

        public Task<int> DeletePersona(Models.Personas persona)
        {
            return _connection.DeleteAsync(persona);
        }
    }
}
