using SafariGolf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SafariGolf.ViewModels
{
    public class EventFormViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Please enter the event name.")]
        [StringLength(255)]
        [Display(Name = "Event / Tournament Title")]
        public string Title { get; set; }

        [Display(Name = "Event / Tournament Description")]
        public string Description { get; set; }

        [Display(Name = "Date / Time of Event")]
        public DateTime? EventDate { get; set; }

        public string Host { get; set; }

        public string Venue { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        [Display(Name = "Is Event Active?")]
        public bool IsActive { get; set; }

        public EventType EventType { get; set; }

        [Display(Name = "Event Type")]
        public byte EventTypeId { get; set; }

        public IEnumerable<EventType> EventTypes { get; set; }
    }
}