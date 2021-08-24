﻿using SaintSender.Core.Interfaces;
using SaintSender.Core.Models;

namespace SaintSender.Core.Services
{
    public class AccountService : IAccountService
    {
        public string Authenticate(string email, string password)
        {
            return Authentication.AuthenticateAccount(email, password);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
		}

        public bool VerifyPassword(string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
