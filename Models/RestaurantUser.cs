namespace CoolApi.Models

{
    public class User {
        public int userId { get; set; }//ColumnNames***
        public string userName { get; set; }
        public string password { get; set; }
        public int employeeId { get; set; }
        public int createBy { get; set; }

    }
}