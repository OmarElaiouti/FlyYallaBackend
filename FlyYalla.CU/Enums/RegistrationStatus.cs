﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyYalla.CU.Enums
{
    public enum RegistrationStatus
    {
        Success,
        UserAlreadyExists,
        PasswordValidationFailed,
        DisagreeTerms,
        UnexpectedError
    }
}
