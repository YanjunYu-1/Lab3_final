﻿namespace Lab3_final.Data.DAL
{
    public interface IDAL<T> where T : class
    {
        void Create(T entity);
        T Get(int id);
        T Get(Func<T, bool> func);
        ICollection<T> GetAll();
        ICollection<T> GetList(Func<T, bool> wherefunc);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
