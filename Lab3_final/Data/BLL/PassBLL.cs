using Lab3_final.Data.DAL;
using Lab3_final.Models;

namespace Lab3_final.Data.BLL
{
    public class PassBLL
    {
        IDAL<Pass> repo;
        public PassBLL(IDAL<Pass> repository)
        {
            this.repo = repository;
        }

        public void CreatePass(Pass pass)
        {
            if(pass.Name.Length>=3 && pass.Name.Length <= 20)
            {
                repo.Create(pass);
            }
            else
            {
                throw new Exception("the Purchaser argument must  between 3 and 20 characters long");
            }
        }
        public List<Pass> GetAll()
        {
            return repo.GetAll().ToList();
        }
    }
}
