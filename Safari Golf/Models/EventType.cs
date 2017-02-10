using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SafariGolf.Models
{
    public class EventType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public static readonly byte Tournament = 0;
        public static readonly byte Mug = 1;
        public static readonly byte MiniMaster = 2;
        public static readonly byte Other = 3;
    }
}