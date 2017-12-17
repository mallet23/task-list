using System.Web.Http;
using System.Web.Http.Description;
using TaskList.Abstractions.Services;
using TaskList.Entities;
using TaskList.ViewModels;

namespace TaskList.Controllers
{
    public class UserSettingsController : BaseApiController
    {
        private IUserSettingsService UserSettingsService { get; }

        public UserSettingsController(IUserSettingsService userSettingsService)
        {
            UserSettingsService = userSettingsService;
        }

        [HttpGet]
        [ResponseType(typeof(UserSettingsModel))]
        public IHttpActionResult GetUserSettings()
        {
            var userSettings = UserSettingsService.GetSettings();
            var model = new UserSettingsModel
            {
                Color = userSettings.Color,
                DateTimeFormat = userSettings.DateTimeFormat
            };

            return Ok(model);
        }

        [HttpPut]
        public IHttpActionResult UpdateSettings([FromBody] UserSettingsModel userSettingsModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var userSettings = new UserSettings
            {
                Color = userSettingsModel.Color,
                DateTimeFormat = userSettingsModel.DateTimeFormat
            };

            UserSettingsService.UpdateUserSettings(userSettings);

            return Ok();
        }
    }
}