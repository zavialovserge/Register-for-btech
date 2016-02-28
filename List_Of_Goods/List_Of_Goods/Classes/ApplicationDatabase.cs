using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
namespace List_Of_Goods
{
    class ApplicationDatabase
    {
        #region Connection to database
        public static SqlConnection getConnection()
        {
            string connectString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\goodsDatabase.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectString);
            return conn;
        }
        #endregion
        #region Add function
        public static void AddGoods(string name, float amount, float procurementPrice, string categoryOfGoods)
        {
            string insertStr = "INSERT INTO GOODS (Name,Amount,ProcurementPrice,CategoryOfGoods) VALUES (@name,@amount,@procurementPrice,@categoryOfGoods)";
            SqlConnection conn = getConnection();
            SqlCommand comm = new SqlCommand(insertStr, conn);
            comm.Parameters.AddWithValue("@name", name);
            comm.Parameters.AddWithValue("@amount", amount);
            comm.Parameters.AddWithValue("@procurementPrice", procurementPrice);
            comm.Parameters.AddWithValue("@categoryOfGoods", categoryOfGoods);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw; }
            finally { conn.Close(); }
        }
        #endregion
        #region List of goods
        public static List<Goods> getGoods()
        {
            List<Goods> goodsList = new List<Goods>();
            SqlConnection conn = getConnection();
            string seeAll = "SELECT * FROM Goods ORDER BY Name";
            SqlCommand comm = new SqlCommand(seeAll, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Goods goods = new Goods(reader["Name"].ToString(), Convert.ToSingle(reader["Amount"]), Convert.ToSingle(reader["ProcurementPrice"]), reader["CategoryOfGoods"].ToString());
                    goodsList.Add(goods);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw; }
            finally { conn.Close(); }
            return goodsList;
        }
        #endregion
        #region Delete function
        public static void Delete(string value)
        {
            string insertStr = "DELETE FROM Goods WHERE Name = @VALUE";
            SqlConnection conn = getConnection();
            SqlCommand insertComm = new SqlCommand(insertStr, conn);
            insertComm.Parameters.Add("@VALUE", value);
            try
            {
                conn.Open();
                insertComm.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw; }
            finally { conn.Close(); }
        }
        #endregion
        #region Indexation Function
        public static void Indexation(float index)
        {
            float _index = 1;
            string insertStr = "Update GOODS SET ProcurementPrice = ProcurementPrice*@indexer";
            SqlConnection conn = getConnection();
            SqlCommand Comm = new SqlCommand(insertStr, conn);
            _index = index / 100 + 1;
            Comm.Parameters.Add("@indexer", _index);
            try
            {
                conn.Open();
                Comm.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw; }
            finally { conn.Close(); }
        }
        #endregion
    }


}
