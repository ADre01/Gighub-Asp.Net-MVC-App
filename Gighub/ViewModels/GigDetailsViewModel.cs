using Gighub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gighub.ViewModels
{
    public class GigDetailsViewModel
    {
        public Gig Gig { get; set; }
        public bool IsAttending { get; set; }
        public bool IsFollowing { get; set; }
    }
}