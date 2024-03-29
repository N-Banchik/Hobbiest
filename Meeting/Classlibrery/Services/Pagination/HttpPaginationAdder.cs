﻿using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace DataAccess.Services.Pagination
{
    public static class HttpPaginationAdder
    {
        public static void AddPaginationHeader(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var options = new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            PaginationHeader paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader, options));

            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}
