﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBCW2.Bussiness.Service.Auth
{
    public class AuthService : IAuthService
    {
        public bool ValidateToken(string token)
        {
            // Basit bir kullanıcı doğrulama
            return token == "1234";
        }
    }
}
