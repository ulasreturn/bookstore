using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class OrdersController : BaseCrudController<Orders, int, CreateOrdersDto, UpdateOrdersDto, OrdersInfoDto>
    {
        public OrdersController(IOrdersService service) : base(service)
        {
        }

    }
}
