using Api.Interfaces.UserProfile.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController : Controller
    {
        private readonly IMediator _mediator;

        public UserProfilesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAllProfiles()
        {
            return (IActionResult)Task.FromResult(Ok());
        }

        [HttpGet]
        public IActionResult GetUserProfile(int id)
        {
            return (IActionResult)Task.FromResult(Ok());
        }

        [HttpPost]
        public IActionResult CreateUUserProfile(UserProfileCreate userProfileData)
        {
            return (IActionResult)Task.FromResult(Ok());
        }
    }
}
