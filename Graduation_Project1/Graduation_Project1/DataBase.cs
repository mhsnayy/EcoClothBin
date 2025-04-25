using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Graduation_Project1
{
    class DataBase
    {
        public NpgsqlConnection connection()
        {
            //aws
            //NpgsqlConnection connect = new NpgsqlConnection("Host = my-gp-instance.czouueuq4g42.us-east-1.rds.amazonaws.com; Port = 5432; Username = postgres; Password = EcoClothBin2025.; Database = postgres;Timeout=30; ");
            NpgsqlConnection connect = new NpgsqlConnection("Host=localhost; Port=5432; Username=postgres; Database=gp; Timeout=30;");

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            else
            {
                MessageBox.Show("Connection is already open. Please close!!");
            }
            return connect;
        }


    }
}
