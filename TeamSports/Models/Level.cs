﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamSports.Models
{
    public class Level
    {
        public Guid ID { get; set; }
        [Display(Name = "Level")]
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}