using Lab3_final.Models;

namespace Lab3_final.Data.DAL
{
    public class PassDAL : IDAL<Pass>
    {
        public Lab3_finalContext db { get; set; }
        public PassDAL(Lab3_finalContext com)
        {
            db = com;
        }
        public void Create(Pass entity)
        {
            db.Add(entity);
        }

        public void Delete(Pass entity)
        {
            db.Pass.Remove(entity);
        }

        public Pass Get(int id)
        {
            return db.Pass.First(x => x.Id == id);
        }

        public Pass Get(Func<Pass, bool> func)
        {
            return db.Pass.First(func);
        }

        public ICollection<Pass> GetAll()
        {
            return db.Pass.ToList();
        }

        public ICollection<Pass> GetList(Func<Pass, bool> wherefunc)
        {
            return db.Pass.Where(wherefunc).ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Pass entity)
        {
            db.Pass.Update(entity);
        }
    }
}
