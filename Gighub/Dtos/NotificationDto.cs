using Gighub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gighub.Dtos
{
    public class NotificationDto
    {
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; set; }
        public string OriginalVenue { get; set; }
        public DateTime? OriginalDateTime { get; set; }
        public GigDto Gig { get; set; }
    }
}