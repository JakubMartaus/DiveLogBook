using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace DiveLogBook
{
    public class TodoItemDatabase
    {
        private SQLiteConnection database;
       
  

        public TodoItemDatabase(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<TodoItem>();
        }
        public List<TodoItem> GetItemsAsync()
        {
            return null;
            // return database.Table<TodoItem>();
        }
        public  List<TodoItem> GetItemsNotDoneAsync()
        {
            return  database.Query<TodoItem>("SELECT * FROM [TodoItem]");
        }
        public TodoItem GetItemAsync(int id)
        {
            return database.Table<TodoItem>().Where(i => i.ID == id).FirstOrDefault();
        }
        public int SaveItemAsync(TodoItem item)
        {
            if (item.ID != 0)
            {
                return database.Update(item);
            }
            else
            {
                return database.Insert(item);
            }
        }
        public int DeleteItemAsync(TodoItem item)
        {
            return database.Delete(item);
        }
    }
}
