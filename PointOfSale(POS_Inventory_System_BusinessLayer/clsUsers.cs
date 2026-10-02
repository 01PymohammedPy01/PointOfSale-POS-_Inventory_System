using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale_POS_Inventory_System_DataLayer;

namespace PointOfSale_POS_Inventory_System_BusinessLayer
{
    public class clsUsers
    {
        enum enMode { AddMode = 1, UpdateMode = 2 }
        enMode Mode = enMode.AddMode;

        public int UserID { get; set; }
        public string FullName { get; set; }
        public string UserRole { get; set; }
        public string Password { get; set; }

        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static bool RemoveUser(int UserID)
        {
            return clsUsersData.RemoveUser(UserID);
        }

        public clsUsers(int UserID, string FullName, string UserRole, string Password)
        {
            this.UserID = UserID;
            this.FullName = FullName;
            this.UserRole = UserRole;
            this.Password = Password;
            Mode = enMode.UpdateMode;
        }

        public clsUsers()
        {
            this.UserID = -1;
            this.FullName = "";
            this.UserRole = "";
            this.Password = "";
            Mode = enMode.AddMode;
        }

        public static DataTable GetUserInfo(int UserID,string Password)
        {
           return  clsUsersData.GetUserLoginInfo(UserID,Password);
        }
        private bool _AddUser()
        {
            return clsUsersData.AddNewUser(this.FullName, this.UserRole, this.Password);
        }

        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.UserID, this.FullName, this.UserRole, this.Password);
        }

        public void Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    if (_AddUser())
                    {
                        Mode = enMode.UpdateMode;
                    }
                    break;

                case enMode.UpdateMode:
                    _UpdateUser();
                    break;
            }
        }
    }
}