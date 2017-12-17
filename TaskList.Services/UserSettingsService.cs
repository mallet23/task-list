using System.Linq;
using TaskList.Abstractions.Repositories;
using TaskList.Abstractions.Services;
using TaskList.DbEntities;
using TaskList.Entities;
using TaskList.Services.Constants;

namespace TaskList.Services
{
    public class UserSettingsService : BaseService, IUserSettingsService
    {
        public UserSettingsService(IRepository repository)
            : base(repository)
        {
        }

        public UserSettings GetSettings()
        {
            using (var context = Repository.CreateContext())
            {
                var dbUserSettings =  context.Set<DbUserSettings>().FirstOrDefault();

                return new UserSettings
                {
                    Color = dbUserSettings?.Color ?? Defaults.GridRowColorHex,
                    DateTimeFormat = dbUserSettings?.DateTimeFormat ?? Defaults.DateTimeFormat
                };
            }
        }

        public void UpdateUserSettings(UserSettings userSettings)
        {
            using (var context = Repository.CreateContext())
            {
                // Just one for now
                var dbUserSettings = context.Set<DbUserSettings>().FirstOrDefault();

                if (dbUserSettings == null)
                {
                    context.Set<DbUserSettings>().Add(new DbUserSettings
                    {
                        Color = userSettings.Color,
                        DateTimeFormat = userSettings.DateTimeFormat
                    });
                }
                else
                {
                    dbUserSettings.Color = userSettings.Color;
                    dbUserSettings.DateTimeFormat = userSettings.DateTimeFormat;
                }

                context.SaveChanges();
            }
        }
    }
}