using DBWorker;
using System.Data;

namespace WinFormCoreLIb

{


    public class User
    {

        public string Username { get; set; }
        public string Password { get; set; }


        public static DataSet Search()
        {
            string cmd = @$" Select * from m124_Login";


            var res = DataBaseWorker.Select(cmd);

            return res;


        }


        public static bool Delete(int ID)
        {
            string cmd = @$"Delete from m124_Login  
                                     where  ID = {ID} ";


            DataBaseWorker.Execute(cmd);


            return true;

        }

        public static DataSet Get()
        {
            string cmd = @$" Select * from m124_Login";


            var res = DataBaseWorker.Select(cmd);

            return res;

        }

        public static bool Login(string Username, string Password)
        {
            string cmd = @$" Select * from m124_Login
                                     where  Username = '{Username}' And Password = '{Password}' ";


            var res = DataBaseWorker.Select(cmd);
            if (res.Tables[0].Rows.Count == 1)
            {
                return true;
            }

            return false;

        }

        public static bool Registration(string Username, string Password)
        {
            string cmd = @$"insert into m124_Login  
                                     values ('{Username}','{Password}')";


            DataBaseWorker.Execute(cmd);


            return true;

        }


    }
}
