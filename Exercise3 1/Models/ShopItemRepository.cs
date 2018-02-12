using Exercise3_1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Exercise3_1.Models
{
    public class ShopItemRepository: IShopItemRepository, IDisposable
    {
        CodeMigrationsContext context;
        public List<ShopItem>  GetUsers(int id, string name)
        {
            return null;
        }
        public ShopItemRepository(CodeMigrationsContext context)
        {
            this.context = context;
        }
        public void DeleteItem(int itemID)
        {
           
        }
        public ShopItem GetItemByID { get; set; }

        public IEnumerable<ShopItem> GetItmes { get; set; }
        public void Save()
        {

        }

        public void UpdateItem(ShopItem item)
        {

        }

        public void Dispose()
        {
            context.Dispose();
        }

        IEnumerable<User> IShopItemRepository.GetUsers()
        {
            throw new NotImplementedException();
        }

        User IShopItemRepository.GetUserByID(int userID)
        {
            
            ShopItem shopItem = context.ShopItems.Find(userID);
            
            return IView(shopItem);
            
        }

        void IShopItemRepository.InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        void IShopItemRepository.UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        void IShopItemRepository.DeleteUser(int userID)
        {
            throw new NotImplementedException();
        }

        void IShopItemRepository.Save()
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}