using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_DataLayer
{
    public class clsSalesData
    {
        public static DataTable GetAllSales()
        {
            DataTable SalesDT = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = "SELECT * FROM Sales";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        try
                        {
                            Adapter.Fill(SalesDT);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                Connection.Close();

            }
            return SalesDT;
        }

        public static decimal GetSalesOfToday()
        {
            decimal SalesOfToday = 0;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"select Sum(Sales.TotalAmount) From Sales
                                where cast(Sales.SaleDate as DATE) = Cast(GETDATE() as Date) ";

                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    {
                        try
                        {
                            object result = Command.ExecuteScalar();
                            if (result != null && decimal.TryParse(result.ToString(), out decimal Count))
                            {
                                SalesOfToday = Count;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                Connection.Close();

            }
            return SalesOfToday;
        }
        public static DataTable GetLast10SaleItems()
        {
           


            DataTable SalesDT = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"select top 10 Products.ProductName,Sales.SaleDate,Sales.TotalAmount from SaleItems
                            inner join Sales on Sales.SaleID = SaleItems.SaleID
                            inner join Products on Products.ProductID = SaleItems.ProductID
                            order by Sales.SaleID desc";

                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        try
                        {
                            Adapter.Fill(SalesDT);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                Connection.Close();

            }
            return SalesDT;


        }

        public static int AddNewSale(int UserID, DateTime SaleDate, decimal TotalAmount)
        {
            int SaleID = -1;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"INSERT INTO Sales (UserID, SaleDate, TotalAmount)
                                 VALUES (@UserID, @SaleDate, @TotalAmount)
                                 Select Scope_Identity()";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserID", UserID);
                    Command.Parameters.AddWithValue("@SaleDate", SaleDate);
                    Command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                    try
                    {
                        object ID = Command.ExecuteScalar();
                        if (ID != null)
                        {
                            SaleID = Convert.ToInt32(ID);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    Connection.Close();

                }
            }
            return SaleID;
        }

        public static bool RemoveSale(int SaleID)
        {
            bool IsDeleted = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = "DELETE FROM Sales WHERE SaleID = @SaleID";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@SaleID", SaleID);

                    try
                    {
                        int RowsAffected = Command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsDeleted = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    Connection.Close();

                }
            }
            return IsDeleted;
        }

        public static bool UpdateSale(int SaleID, int UserID, DateTime SaleDate, decimal TotalAmount)
        {
            bool IsUpdated = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"UPDATE Sales SET UserID = @UserID,
                                                 SaleDate = @SaleDate,
                                                 TotalAmount = @TotalAmount
                                           WHERE SaleID = @SaleID";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@SaleID", SaleID);
                    Command.Parameters.AddWithValue("@UserID", UserID);
                    Command.Parameters.AddWithValue("@SaleDate", SaleDate);
                    Command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                    try
                    {
                        int RowsAffected = Command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsUpdated = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    Connection.Close();

                }
            }
            return IsUpdated;
        }
    }
}