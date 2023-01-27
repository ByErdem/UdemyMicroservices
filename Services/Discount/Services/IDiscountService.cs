﻿using FreeCourse.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Discount.Services
{
    public interface IDiscountService
    {
        Task<Response<List<Models.Discount>>> GetAll();
        Task<Response<Models.Discount>> GetById(int id);
        Task<Response<NoContent>> Save(Models.Discount discount);
        Task<Response<NoContent>> DeleteById(int id);
        Task<Response<NoContent>> UpdateById(Models.Discount discount);
        Task<Response<Models.Discount>> GetByCodeAndUserId(string code, string userId);
    }
}