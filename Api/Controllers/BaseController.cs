using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanWeatherForecast.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;

        protected BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
