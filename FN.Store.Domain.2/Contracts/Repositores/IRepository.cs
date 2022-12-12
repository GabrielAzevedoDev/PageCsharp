using FN.Store.Domain._2.Entities;
using System;
using System.Collections.Generic;

namespace FN.Store.Domain._2.Contracts.Repositores
{
    public interface IRepository
    <T> : IDisposable where T : Entity
    {
        IEnumerable<T> Get();
        T Get(int id);


        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);

    }
}
