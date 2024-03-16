using Application.Features.Brands.Models;
using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListByDynamicModel;
using Application.Features.Models.Queries.GetListModel;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new GetListModelQuery {PageRequest = pageRequest};
            ModelListModel result = await Mediator.Send(getListModelQuery);

            return Ok(result);
        }

        [HttpPost("GetList/ByDynamic")]
        public async Task<IActionResult> GetDynamicList([FromQuery] PageRequest pageRequest, Dynamic dynamic)
        {
            GetListByDynamicModelQuery getListByDynamicModelQuery = new GetListByDynamicModelQuery { PageRequest = pageRequest, Dynamic = dynamic};
            ModelListModel result = await Mediator.Send(getListByDynamicModelQuery);

            return Ok(result);
        }

    }
}
