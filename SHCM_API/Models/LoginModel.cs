using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHCM_API.Models
{
    public class LoginModel
    {
        private string mSSV;
        private string email;

        public string MSSV { get => mSSV; set => mSSV = value; }
        public string Email { get => email; set => email = value; }

        public LoginModel(string mSSV, string email)
        {
            MSSV = mSSV;
            Email = email;
        }
    }
}