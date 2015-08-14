using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReminderApplication.Models;

namespace ReminderApplication.DAL
{
    public class ItemsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReminderAppContext>
    {
        protected override void Seed(ReminderAppContext context)
        {
            var items = new List<Item>
            {
                new Item {Id = 1, Title = "Wacked", Content = "Ride the pine"},
                new Item {Id = 2, Title = "A new day", Content = "Today is a new day"},
                new Item {Id = 3, Title = "Razzle", Content = "Why are people razzling and dazzling?"}
            };
            items.ForEach(i => context.Items.Add(i));
            context.SaveChanges();

        }
    }
}
