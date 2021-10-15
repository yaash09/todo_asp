using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApp_Backend.Models
{
    public class Item
    {
        public int id { get; set; } = 0;
        public string title { get; set; } = "";
        public string note { get; set; } = "";
        public string priority { get; set; } = null;
    }
}