using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SafariGolf.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the event name.")]
        [StringLength(255)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Date of Event")]
        public DateTime? EventDate { get; set; }

        public string Host { get; set; }

        public string Venue { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public bool IsActive { get; set; }

        public EventType EventType { get; set; }

        [Display(Name = "Event Type")]
        public byte EventTypeId { get; set; }
    }
}