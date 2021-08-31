using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHCM_API.Models
{
    public class DetailAccount
    {
        private int status;
        private Account account;

        public int Status { get => status; set => status = value; }
        public Account Account { get => account; set => account = value; }

        public DetailAccount(int status, Account account)
        {
            this.status = status;
            this.account = account;
        }
    }
}