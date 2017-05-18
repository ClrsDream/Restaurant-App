﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.DataTransferObjects;
using Restaurant.Model;

namespace Restaurant.Abstractions.Managers
{
    public interface IAuthenticationManager
    {
        Task<AuthenticationResult> Login(LoginDto loginDto);

        Task<bool> Register(RegisterDto registerDto);

        Task<bool> ValidateToken(string accessToken);

        Task<bool> LogOut();
    }
}