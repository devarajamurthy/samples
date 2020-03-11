using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SeminarInvite.Models
{
    public class GuestDbContext : DbContext
    {
        public DbSet<GuestResponse> GuestResponses { get; set; }
    }
}