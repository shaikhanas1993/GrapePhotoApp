﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.API
{
    public class SignUpDto
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }
    }
}
