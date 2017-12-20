using CafeTNT_Management.Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeTNT_Management.Repository.Interface
{
    public interface IUserMasterRepository
    {
        IEnumerable<UserMasterDTO> GetAll();
        UserMasterDTO Get(int id);
        UserMasterDTO Add(UserMasterDTO item);
        bool Update(UserMasterDTO item);
        bool Delete(int id);
    }
}
