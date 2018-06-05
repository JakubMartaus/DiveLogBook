using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DiveLogBook
{
   public class ItemTable
   {
       [PrimaryKey, AutoIncrement]
       public int ID { get; set; }
       public string Country { get; set; }
    }
}
