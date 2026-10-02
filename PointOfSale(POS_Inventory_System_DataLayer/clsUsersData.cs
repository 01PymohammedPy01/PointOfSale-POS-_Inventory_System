using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_POS_Inventory_System_DataLayer
{
    public class clsUsersData
    {
        public static DataTable GetAllUsers()
        {
            DataTable UsersDT = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = "SELECT Users.UserID,Users.FullName,Users.UserRole,Users.Password FROM Users where IsActive = 1";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    using (SqlDataAdapter Adapter = new SqlDataAdapter(Command))
                    {
                        try
                        {
                            Adapter.Fill(UsersDT);
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                Connection.Close();

            }
            return UsersDT;
        }


        public static DataTable GetUserLoginInfo(int UserID,string Password)
        {

            DataTable UserRecord = new DataTable();

            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"select UserID,UserRole,FullName,Password From Users 
                                Where UserID = @UserID and Password = @Password";
                Connection.Open();


                using(SqlCommand Command = new SqlCommand(Query,Connection))
                {

                    Command.Parameters.AddWithValue("@UserID",UserID);
                    Command.Parameters.AddWithValue("@Password",Password);

                    
                    using(SqlDataAdapter ReadUser = new SqlDataAdapter(Command))
                    {
                        ReadUser.Fill(UserRecord);
                    }
                }


            }
            return UserRecord;



        }


        public static bool AddNewUser(string FullName, string UserRole, string Password)
        {
            bool IsAdded = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"INSERT INTO Users (FullName, UserRole, Password,IsActive)
                                 VALUES (@FullName, @UserRole, @Password,1)";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@FullName", FullName);
                    Command.Parameters.AddWithValue("@UserRole", UserRole);
                    Command.Parameters.AddWithValue("@Password", Password);

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

        public static bool RemoveUser(int UserID)
        {
            bool IsDeleted = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = "Update Users set Users.IsActive = 0 WHERE UserID = @UserID";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool UpdateUser(int UserID, string FullName, string UserRole, string Password)
        {
            bool IsUpdated = false;
            using (SqlConnection Connection = new SqlConnection(clsPosAndInventoryDataAccess.PosAndInventoryDatabasePath))
            {
                string Query = @"UPDATE Users SET FullName = @FullName,
                                                 UserRole = @UserRole,
                                                 Password = @Password
                                           WHERE UserID = @UserID";
                Connection.Open();

                using (SqlCommand Command = new SqlCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserID", UserID);
                    Command.Parameters.AddWithValue("@FullName", FullName);
                    Command.Parameters.AddWithValue("@UserRole", UserRole);
                    Command.Parameters.AddWithValue("@Password", Password);

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