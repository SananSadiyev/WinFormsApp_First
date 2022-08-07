using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWorker
{
    public class DataBaseWorker
    {
        private const string connString = @"Server=DESKTOP-U861E2K\SQLEXPRESS;Database=dev;Encrypt=false;Trusted_Connection=True;";

        public static SqlConnection SqlConnection { get; private set; }

        static DataBaseWorker()
        {
            SqlConnection = new SqlConnection(connString); 

        }

        public static void Execute(string cmd)
        {
            try
            {
                SqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(cmd, SqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                SqlConnection.Close();
            }
            

        }

     
        public static DataSet Select(string cmd)
        {
            try
            {
                DataSet dataset = new DataSet();

                SqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd,SqlConnection);
                adapter.Fill(dataset);

                return dataset;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SqlConnection.Close();
            }


        }
    }
}
