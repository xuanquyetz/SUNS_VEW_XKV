using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///*/*using System.Windows.Forms**//;
using System.Data.SqlClient;
using System.Data;


namespace SUNS_VEW
{
    public class KeNoiData // Tạo class ket nối
    {
        private static KeNoiData instance; //Ctrl+.
        
        public static KeNoiData Instance
        {
            get
            { if (instance == null) instance = new KeNoiData();
                return instance;
            }

           private set
            {
              KeNoiData.instance = value;
            }
        }
        private KeNoiData() { }
        // private string connectionstr = @"Data Source=APPLE5460;Initial Catalog=SUNS_HIS;Integrated Security=True";
       // private string connectionstr = @"Data Source=192.168.1.251;Initial Catalog=SUNS_PKTINDUC;User ID=suns;Password=sunssql@2019";
       // private string connectionstr = @"Data Source=115.79.29.62;Initial Catalog=SUNS_PKASIANPHUMY_TEST;User ID=suns;Password=sunssql@2019";
        private string connectionstr = @"Data Source=115.79.217.229;Initial Catalog=SUNS_YDUOCMIENDONG;User ID=suns;Password=sunssql@2019";
        //private string connectionstr = @"Data Source=192.168.1.219;Initial Catalog=SUNS_YDUOCMIENDONG;User ID=suns;Password=sunssql@2019";

        //public DataTable KetNoiData(string query)
        public DataTable ExecuteQuery(string query,object[] paramater =null)
            
       {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionstr)) 
            
            {

                connection.Open();

                SqlCommand Command = new SqlCommand(query, connection);
               // SqlDependency de = new SqlDependency(Command);

                if (paramater !=null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach( string Item in listPara)
                    {
                        if (Item.Contains('@'))
                        {
                            Command.Parameters.AddWithValue(Item, paramater[i]);
                            i++;
                        }

                    }

                }
                SqlDataAdapter adapter = new SqlDataAdapter(Command);

                adapter.Fill(data);
                connection.Close();
               
            }
            return data;
        }


        public int ExecuteNonQuery(string query, object[] paramater = null)

        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionstr))

            {

                connection.Open();

                SqlCommand Command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string Item in listPara)
                    {
                        if (Item.Contains('@'))
                        {
                            Command.Parameters.AddWithValue(Item, paramater[i]);
                            i++;
                        }

                    }

                }

                data = Command.ExecuteNonQuery();
                connection.Close();

            }
            return data;
        }


        public object ExecuteScalar(string query, object[] paramater = null)

        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionstr))

            {

                connection.Open();

                SqlCommand Command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string Item in listPara)
                    {
                        if (Item.Contains('@'))
                        {
                            Command.Parameters.AddWithValue(Item, paramater[i]);
                            i++;
                        }

                    }

                }

                data = Command.ExecuteScalar();
                connection.Close();

            }
            return data;
        }
    }

}
