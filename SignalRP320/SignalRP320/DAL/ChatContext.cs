using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignalRP320.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRP320.DAL
{
    public class ChatContext:IdentityDbContext<AppUser>
    {
        public ChatContext(DbContextOptions<ChatContext> options):base(options) {}
    }
}
