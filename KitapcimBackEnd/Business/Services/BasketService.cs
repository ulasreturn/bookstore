﻿using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BasketService : BaseService<Basket, int, BasketInfoDto>, IBasketService
    {
        public BasketService(IUnitOfWork unitOfWork, IMapperHelper mapperHelper) : base(unitOfWork, unitOfWork.Basket, mapperHelper)
        {
        }
    }
}
