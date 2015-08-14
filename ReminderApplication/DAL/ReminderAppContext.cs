using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReminderApplication.Models;

namespace ReminderApplication.DAL
{
    public class ReminderAppContext : DbContext
    {
        public ReminderAppContext() : base ("ReminderAppContext")
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}
