namespace Exercise3_1.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeMigrationsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(CodeMigrationsContext context)
        {

            var users = new List<User>
            {
                new User() {UserName="Tom Petty", Balance=200 },
                new User() {UserName="Mary Hardy", Balance=100 },
                new User() {UserName="Eileen Savage", Balance=1000 },
                new User() {UserName="Yellow Hell", Balance=750 },
            };

            var items = new List<ShopItem>
            {
                new ShopItem() {Name="Small Health", Cost=50, Class=ItemClass.Health, ImageURL="~/Content/Images/health_icon.png" },
                new ShopItem() {Name="Big Health", Cost=100, Class=ItemClass.Health, ImageURL="~/Content/Images/health_icon.png" },
                new ShopItem() {Name="Small Magic", Cost=50, Class=ItemClass.Magic, ImageURL="~/Content/Images/magic_icon.png" },
                new ShopItem() {Name="Big Magic", Cost=100, Class=ItemClass.Magic, ImageURL="~/Content/Images/magic_icon.png" },
                new ShopItem() {Name="Small Stamina", Cost=50, Class=ItemClass.Stamina, ImageURL="~/Content/Images/stamina_icon.png" },
                new ShopItem() {Name="Big Stamina", Cost=100, Class=ItemClass.Stamina, ImageURL="~/Content/Images/stamina_icon.png" },

            };

            users.ForEach(u => context.Users.Add(u));
            items.ForEach(i => context.ShopItems.Add(i));

            context.SaveChanges();
        }
    }
}
