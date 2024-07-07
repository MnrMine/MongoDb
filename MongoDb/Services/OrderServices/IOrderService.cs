﻿using MongoDb.Dtos.OrderDtos;
using MongoDb.Models;

namespace MongoDb.Services.OrderServices
{
    public interface IOrderService
    {
        Task<List<ResultOrderDto>> GetAllOrderAsync();
        Task CreateOrderAsync(CreateOrderDto orderDto);
        Task UpdateOrderAsync(UpdateOrderDto orderDto);
        Task DeleteOrderAsync(string id);
        Task<GetByIdOrderDto> GetByIdOrderAsync(string id);
        Task<List<ResultOrderWithCustomerWithProductDto>> ResultOrderWithCustomerWithProductDto();
        Task<List<OrderWithCustomerListPdfViewModel>> GetOrderListViewModels();
    }
}
