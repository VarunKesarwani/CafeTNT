using CafeTNT_Management.Repository.DataSource;
using CafeTNT_Management.Repository.DTO;
using CafeTNT_Management.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeTNT_Management.Repository.Repository
{
    public class UserMasterRepository : IUserMasterRepository
    {
        UserMaster DB = new UserMaster();
        private List<UserMasterDTO> users = new List<UserMasterDTO>();
        private int Id = 1;

        public UserMasterRepository()
        {
            // Add products for the Demonstration  
            Add(new UserMasterDTO { Title = "User1", Author = "user1@test.com", Publisher = "1234567890",Isbn ="abc" });
            Add(new UserMasterDTO { Title = "User2", Author = "user2@test.com", Publisher = "1234567890", Isbn = "abc" });
            Add(new UserMasterDTO { Title = "User3", Author = "user3@test.com", Publisher = "1234567890", Isbn = "abc" });
        }

        public UserMasterDTO Add(UserMasterDTO item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.ID = Id++;
            users.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            users.RemoveAll(p => p.ID == id);
            return true;
        }

        public UserMasterDTO Get(int id)
        {
            return users.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<UserMasterDTO> GetAll()
        {
            return users;
        }

        public bool Update(UserMasterDTO item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }


            int index = users.FindIndex(p => p.ID == item.ID);
            if (index == -1)
            {
                return false;
            }
            users.RemoveAt(index);
            users.Add(item);
            return true;
        }
    }  
}
