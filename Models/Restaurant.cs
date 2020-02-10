using System;
namespace CoolApi.Models
 {
    public class Role {                
        public int roleId { get; set; }
        public string roleName { get; set; }
        // public int active { get; set; }
        public string remark { get; set; }
        public int createBy { get; set; }

        public DateTime createdDate { get; set; }

    }
}