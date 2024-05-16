using Microsoft.EntityFrameworkCore;
using RestWithAspNet.Model;
using RestWithAspNet.Model.Base;
using RestWithAspNet.Model.Context;
using System;

namespace RestWithAspNet.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private MySqlContext _context;
        private DbSet<T> dataSet;
        public GenericRepository(MySqlContext mySqlContext)
        {
            _context = mySqlContext;
            dataSet = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return dataSet.ToList();
        }

        public T FindById(long id)
        {
            return dataSet.SingleOrDefault(p => p.Id == id);
        }

        
        public T Create(T item)
        {
            try
            {
                dataSet.Add(item);
                _context.SaveChanges();

                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(long id)
        {
            var result = dataSet.SingleOrDefault(p => p.Id == id);
            if (result != null)
            {
                try
                {
                    dataSet.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public T Update(T item)
        {
            var result = dataSet.SingleOrDefault(p => p.Id == item.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                return null;
            }
        }

        public bool Exists(long id)
        {
            return dataSet.Any(p => p.Id == id);
        }
    }
}
