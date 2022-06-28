﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.UserManager.Domain.Models
{
    public class AccessTokenResource
    {
        public string IdToken { get; set; }
        public string AccessToken { get; set; }
        public string RefressToken { get; set; }
        public long Expiration { get; set; }
    }
}
