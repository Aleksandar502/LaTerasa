﻿using System.Collections.Generic;
using System.Threading.Tasks;
namespace Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Save();
    }
}
