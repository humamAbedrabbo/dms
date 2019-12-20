﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAS.ViewModels
{
    public class AppUser
    {
        public AppUser()
        {
            Roles = new List<string>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public List<string> Roles { get; set; }

        public bool IsAdmin => Roles?.Contains(Constants.ROLE_ADMIN) ?? false;
        public bool IsArchive => Roles?.Contains(Constants.ROLE_ARCHIVE) ?? false;
        public bool IsPublic => Roles?.Contains(Constants.ROLE_PUBLIC) ?? false;
    }
}
