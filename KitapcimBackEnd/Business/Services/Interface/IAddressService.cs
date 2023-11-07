using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Base.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interface
{
    public interface IAddressService : IBaseService<Address, int, AddressInfoDto>
    {
    }
}
