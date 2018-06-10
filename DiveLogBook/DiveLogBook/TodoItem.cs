using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using SQLite;

namespace DiveLogBook
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Country { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Buddy { get; set; }
        public string Weather { get; set; }
        public string Waves { get; set; }
        public string Boat { get; set; }
        public string Press { get; set; }
        public string Depth { get; set; }
    public TodoItem()
        {

        }
        public override string ToString()
        {
            return "ID" + ID + "Country" + Country + "Location" + Location + "Date" + Date + "Time" + Time + "Buddy" + Buddy + "Weather" + Weather + "Waves" + Waves + "Boat" + Boat + "Presss" + Press + "Depth" + Depth;
        }
    }
}
