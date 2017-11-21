﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace P01_BillsPaymentSystem.Data.Models
{
    class Users
    {

        public Users()
        {
            PaymentMethods = new List<PaymentMethod>();
        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<PaymentMethod> PaymentMethods { get; set; }

    }
}
