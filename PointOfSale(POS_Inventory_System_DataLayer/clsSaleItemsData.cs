using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_DataLayer
{
    public class clsSaleItemsData
    {
        public static DataTable GetAllSaleItems()
        {
            DataTable SaleItemsDT = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = "SELECT * FROM SaleItems";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        try
                        {
                            Adapter.Fill(SaleItemsDT);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        Connection.Close();

                    }
                }
            }
            return SaleItemsDT;
        }

        public static bool AddNewSaleItem(int ProductID, int SaleID, decimal UnitPrice, decimal Quantity)
        {
            bool IsAdded = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"INSERT INTO SaleItems (ProductID, SaleID, UnitPrice, Quantity)
                                 VALUES (@ProductID, @SaleID, @UnitPrice, @Quantity)";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@ProductID", ProductID);
                    Command.Parameters.AddWithValue("@SaleID", SaleID);
                    Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    Command.Parameters.AddWithValue("@Quantity", Quantity);

                    try
                    {
                        int RowsAffected = Command.ExecuteNonQuery();
                        if (RowsAffected > 0)
                        {
                            IsAdded = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    Connection.Close();

                }
            }
            return IsAdded;
        }

        public static bool RemoveSaleItem(int SaleItemID)
        {
            bool IsDeleted = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = "DELETE FROM SaleItems WHERE SaleItemID = @SaleItemID";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@SaleItemID", SaleItemID);

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

        public static bool UpdateSaleItem(int SaleItemID, int ProductID, int SaleID, decimal UnitPrice, decimal Quantity)
        {
            bool IsUpdated = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"UPDATE SaleItems SET ProductID = @ProductID,
                                                     SaleID = @SaleID,
                                                     UnitPrice = @UnitPrice,
                                                     Quantity = @Quantity
                                               WHERE SaleItemID = @SaleItemID";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@SaleItemID", SaleItemID);
                    Command.Parameters.AddWithValue("@ProductID", ProductID);
                    Command.Parameters.AddWithValue("@SaleID", SaleID);
                    Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
                    Command.Parameters.AddWithValue("@Quantity", Quantity);

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