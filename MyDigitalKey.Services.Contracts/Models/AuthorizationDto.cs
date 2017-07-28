﻿using System;

namespace MyDigitalKey.Services.Contracts.Models
{
    public class AuthorizationDto
    {
        public Guid Id { get; set; }
        public UserDto UserDto { get; set; }
        public LockDto Lock { get; set; }
        public bool CanOpen { get; set; }
    }
}