using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers;

public class AddressController : BaseCrudController<Address, int, CreateAddressDto, UpdateAddressDto, AddressInfoDto>
{
    public AddressController(IAddressService service) : base(service)
    {
    }

}
