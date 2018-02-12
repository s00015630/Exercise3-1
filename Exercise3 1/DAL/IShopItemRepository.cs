using Exercise3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise3_1.DAL
{
    public interface IShopItemRepository :IDisposable
    {
        IEnumerable<User> GetUsers();

        //return items
        User GetUserByID(int userID);

        void InsertUser(User user);
        //update
        void UpdateUser(User user);
        void DeleteUser(int userID);
        void Save();

    }
}