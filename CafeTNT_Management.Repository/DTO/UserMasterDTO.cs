using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeTNT_Management.Repository.DTO
{
    public class UserMasterDTO
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
    }
}
