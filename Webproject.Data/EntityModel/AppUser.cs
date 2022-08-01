﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.Enum;

namespace Webproject.Data.EntityModel
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Fullname { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phonenumber { get; set; }
        public string Nation { get; set; }
        public string City { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime LastLogin { get; set; }
        public List<Friend>? RequestFriends { get; set; }
        public List<Friend>? AcceptFriends { get; set; }
        public List<Follow>? Following { get; set; }
        public List<Follow>? Followers { get; set; }
        public List<Post>? Posts { get; set; }
        public List<Share>? Shares { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Reaction>? Reactions { get; set; }
        public List<Reply>? Replys { get; set; }
        public List<Message>? SendMessage { get; set; }
        public List<Message>? ReceiveMessage { get; set; }

    }
}
