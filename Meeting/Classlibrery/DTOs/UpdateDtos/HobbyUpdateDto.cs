﻿namespace DataAccess.DTOs.UpdateDtos
{
    public class HobbyUpdateDto
    {
        public int Id { get; set; }
        public string? HobbyName { get; set; }
        public string? Description { get; set; }
        public string? Rules { get; set; }
        public string? keyFeatures { get; set; }
    }
}
