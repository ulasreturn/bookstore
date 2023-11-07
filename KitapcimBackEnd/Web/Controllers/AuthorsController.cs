using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class AuthorsController : BaseCrudController<Authors, int, CreateAuthorsDto, UpdateAuthorsDto, AuthorsInfoDto>
    {
        public AuthorsController(IAuthorsService service) : base(service)
        {
        }

    }
}
