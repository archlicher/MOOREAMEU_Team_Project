﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Mooreameu.Model;

namespace Mooreameu.Data
{
    public class MooreameuDbContext : IdentityDbContext<User>
    {
        public MooreameuDbContext()
            : base("MooreameuDb", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Reward> Rewards { get; set; }

        public virtual DbSet<Notification> Notifications { get; set; }

        public virtual DbSet<Picture> Pictures { get; set; }

        public virtual DbSet<ProfilePicture> ProfilePictures { get; set; }

        public virtual DbSet<Contest> Contests { get; set; } 

        public static MooreameuDbContext Create()
        {
            return new MooreameuDbContext();
        }
    }
}
