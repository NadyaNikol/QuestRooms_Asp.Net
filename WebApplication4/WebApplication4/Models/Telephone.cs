using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Telephone: IEntity
    {
        //[Key]
        public int Id { get; set; }
        public string Number { get; set; }

        //[ForeignKey("QuestRoom")]
        public int QuestRoomId { get; set; }

        public virtual QuestRoom QuestRoom { get; set; }
    }
}