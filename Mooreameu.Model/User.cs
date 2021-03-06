﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mooreameu.Model
{
    public class User : IdentityUser
    {
        public User()
        {
            this.CreatedContests = new HashSet<Contest>();
            this.ParticipatingInContests = new HashSet<Contest>();
            this.Rewards = new HashSet<Reward>();
            this.Notifications = new HashSet<Notification>();
        }

        public ProfilePicture ProfilePicture { get; set; }

        public UserStatus Status { get; set; }

        public ICollection<Contest> CreatedContests { get; set; }

        public ICollection<Contest> ParticipatingInContests { get; set; }

        public ICollection<Reward> Rewards { get; set; }

        public ICollection<Notification> Notifications { get; set; } 

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
