using PartyInvitesSheilferZepeda.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PartyInvitesSheilferZepeda.DAL
{
    public class InviteContext : DbContext
    {
        public DbSet<GuestResponse> GuestResponses { get; set; }
    }
    
}