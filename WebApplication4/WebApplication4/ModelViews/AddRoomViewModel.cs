using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.ModelViews
{
    public class AddRoomViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public QuestRoom Room { get; set; }
    }
}