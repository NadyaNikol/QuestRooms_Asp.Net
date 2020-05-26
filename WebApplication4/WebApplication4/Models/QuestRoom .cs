using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class QuestRoom : IEntity
    {
        //public QuestRoom() { Telephones = new List<Telephone>(); }

        //[Key]
        public int Id { set; get; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }

        [Display(Name = "Minimal players")]
        public int MinPlayers { get; set; }

        [Display(Name = "Maximum players")]
        public int MaxPlayers { get; set; }
        public string Adress { get; set; }

        //public List<string> Numbers { get; set; }
        //public string Number { get; set; }
        public virtual ICollection<Telephone> Telephones { get; set; }

        public string Email { get; set; }
        public string Company { get; set; }
        public int Rating { get; set; }

        [Display(Name = "Fear level")]
        public int LavelOfFear { get; set; }

        [Display(Name = "Difficulty level")]
        public int LevelOfDifficulty { get; set; }
        public string Logo { get; set; }

        //public override string ToString()
        //{

        //    return $"id - {Id} " +
        //        $"Name -{Name}" +
        //        $"Description -{Description}" +
        //        $"Time -{Time}" +
        //        $"MinPlayers -{MinPlayers}" +
        //        $"MaxPlayers -{MaxPlayers}" +
        //        $"Adress -{Adress}" +
        //        $"Email -{Email}" +
        //        $"Company -{Company}" +
        //        $"Rating -{Rating}" +
        //        $"LavelOfFear -{LavelOfFear}" +
        //        $"LevelOfDifficulty -{LevelOfDifficulty}" +
        //        $"Logo -{Logo}";

        //}

    }
}