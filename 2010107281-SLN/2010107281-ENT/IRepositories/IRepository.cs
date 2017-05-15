using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2010107281_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        /*
        //CREATE
        //Agregar un registro al repositorio (SQL Server) a la tabla TEntity
        void Add(TEntity entity);
        //Agregar un grupo de registros al repositorio a la tabla TEntity
        void AddRange(IEnumerable<TEntity> entities);

        //READS
        //Obtiene el Registro con Primary Key = Id de la tabla TEntity
        TEntity Get(int Id);
        //Obtiene todos los registros de la tabla TEntity
        IEnumerable<TEntity> GetAll();
        //Obtiene todos los registros de la tabal TEntity que cumplan con la condicion predicate es una expresion lamba
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //UPDATE
        //Actualiza un registro al repositorio (SQL Server) a la tabla TEntity
        void Update(TEntity entity);
        //Actualiza un grupo de registros al repositorio a la tabla TEntity
        void UpdateRange(IEnumerable<TEntity> entities);

        //DELETE
        //Elimina un registro al repositorio (SQL Server) a la tabla TEntity
        void Delete(TEntity entity);
        //Elimina un grupo de registros al repositorio a la tabla TEntity
        void DeleteRange(IEnumerable<TEntity> entities);*/
    }
}
