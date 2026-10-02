using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_DataLayer
{
    public class clsCategoryData
    {


        public static DataTable GetAllCategories()
        {
            DataTable CategoryDT = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string GetAllCategoryQuery = "select CategoryID,CategoryName From Category";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(GetAllCategoryQuery, Connection))
                {

                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        try
                        {
                            Adapter.Fill(CategoryDT);
                        }

                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        Connection.Close();
                        
                    }

                }


            }
            return CategoryDT;

        }


        public static bool AddNewCategory(string CategoryName)
        {
            bool IsAdded = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string AddCategoryQuery = @"Insert Into Category(CategoryName)
                                            Values(@CategoryName)";

                Connection.Open();


                using (SqlCommand Command = new SqlCommand(AddCategoryQuery, Connection))
                {
                    Command.Parameters.AddWithValue("@CategoryName", CategoryName);
                

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

                    Connection.Close();

                }
                return IsAdded;


            }
        }


        public static bool RemoveCategory(int CategoryID)
        {
            bool IsDeleted = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string RemoveCategoryQuery = @"Delete From Category Where CategoryID = @CategoryID";
                Connection.Open();



                using (SqlCommand Command = new SqlCommand(RemoveCategoryQuery, Connection))
                {
                    Command.Parameters.AddWithValue("@CategoryID", CategoryID);


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
                    Connection.Close();


                }
                return IsDeleted;


            }
        }


        public static bool UpdateCategory(int CategoryID, string CategoryName)
        {
            bool IsUpdated = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string UpdateCategoryQuery = @"Update Products Set CategoryName= @CategoryName";
                Connection.Open();



                using (SqlCommand Command = new SqlCommand(UpdateCategoryQuery, Connection))
                {
                    Command.Parameters.AddWithValue("@CategoryName", CategoryName);

                    Command.Parameters.AddWithValue("@CategoryID", CategoryID);

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
                    Connection.Close();


                }
                return IsUpdated;


            }
        }




    }
}
