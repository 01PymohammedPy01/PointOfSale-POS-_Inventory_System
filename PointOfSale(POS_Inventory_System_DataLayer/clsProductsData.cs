using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_DataLayer
{
    public class clsProductsData
    {
        public static DataTable GetAllProduct()
        {
            DataTable ProductDT = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string GetAllProductQuery = @"Select Products.ProductID, Products.ProductName, Products.ProductPrice, Products.CurrentStock, 
                                             PicturePath, Category.CategoryName, Category.CategoryID 
                                             from Products 
                                             inner join Category on Category.CategoryID = Products.CategoryID 
                                             where Products.IsActive = 1";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(GetAllProductQuery, Connection))
                {
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        try
                        {
                            Adapter.Fill(ProductDT);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
            return ProductDT;
        }

        public static bool DeductStock(int ProductID, int DeductQuantity)
        {
            bool IsAffected = false;

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                Connection.Open();
                string DeductStockQuery = @"Update Products set CurrentStock = CurrentStock - @DeductQuantity
                                            Where ProductID = @ProductID and IsActive = 1";

                using (SqlCommand Command = new SqlCommand(DeductStockQuery, Connection))
                {
                    Command.Parameters.AddWithValue("@ProductID", ProductID);
                    Command.Parameters.AddWithValue("@DeductQuantity", DeductQuantity);

                    try
                    {
                        int RowsEffected = Command.ExecuteNonQuery();
                        if (RowsEffected > 0)
                        {
                            IsAffected = true;
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return IsAffected;
        }

        public static int GetLowStockItems()
        {
            int LowStockItemAmount = 0;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"select Count(*) from Products where Products.CurrentStock < 5 and Products.IsActive = 1";

                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    try
                    {
                        object result = Command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            LowStockItemAmount = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return LowStockItemAmount;
        }

        public static int GetTotalProducts()
        {
            int TotalProducts = 0;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"select Sum(Products.CurrentStock) from Products where Products.IsActive = 1";

                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    try
                    {
                        object result = Command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int Count))
                        {
                            TotalProducts = Count;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return TotalProducts;
        }

        public static bool AddNewProduct(string ProductName, decimal ProductPrice, int CurrentStock, int CategoryID, string PicturePath)
        {
            bool IsAdded = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string AddProductQuery = @"Insert Into Products(ProductName, ProductPrice, CurrentStock, CategoryID, PicturePath, IsActive)
                                           Values(@ProductName, @ProductPrice, @CurrentStock, @CategoryID, @PicturePath, 1)";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(AddProductQuery, Connection))
                {
                    Command.Parameters.AddWithValue("@ProductName", ProductName);
                    Command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    Command.Parameters.AddWithValue("@CurrentStock", CurrentStock);
                    Command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    Command.Parameters.AddWithValue("@PicturePath", PicturePath);

                    try
                    {
                        int RowsEffected = Command.ExecuteNonQuery();
                        if (RowsEffected > 0)
                        {
                            IsAdded = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return IsAdded;
        }

        public static bool RemoveProduct(int ProductID)
        {
            bool IsDeleted = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string DeleteProductQuery = @"Update Products set IsActive = 0 Where ProductID = @ProductID";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(DeleteProductQuery, Connection))
                {
                    Command.Parameters.AddWithValue("@ProductID", ProductID);

                    try
                    {
                        int RowsEffected = Command.ExecuteNonQuery();
                        if (RowsEffected > 0)
                        {
                            IsDeleted = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return IsDeleted;
        }

        public static bool UpdateProduct(int ProductID, string ProductName, decimal ProductPrice, int CurrentStock, int CategoryID, string PicturePath)
        {
            bool IsUpdated = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string UpdateProductQuery = @"Update Products Set ProductName = @ProductName,
                                                          ProductPrice = @ProductPrice,
                                                          CurrentStock = @CurrentStock,
                                                          CategoryID = @CategoryID,
                                                          PicturePath = @PicturePath 
                                                   Where ProductID = @ProductID";

                Connection.Open();

                using (SqlCommand Command = new SqlCommand(UpdateProductQuery, Connection))
                {
                    Command.Parameters.AddWithValue("@ProductID", ProductID);
                    Command.Parameters.AddWithValue("@ProductName", ProductName);
                    Command.Parameters.AddWithValue("@ProductPrice", ProductPrice);
                    Command.Parameters.AddWithValue("@CurrentStock", CurrentStock);
                    Command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    Command.Parameters.AddWithValue("@PicturePath", PicturePath);

                    try
                    {
                        int RowsEffected = Command.ExecuteNonQuery();
                        if (RowsEffected > 0)
                        {
                            IsUpdated = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            return IsUpdated;
        }
    }
}