﻿namespace DataAccess.DTOs.UpdateDtos
{
    public class PasswordChangeDto
    {
        public string? CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
    }
}
