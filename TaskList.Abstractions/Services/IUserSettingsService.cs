using TaskList.Entities;

namespace TaskList.Abstractions.Services
{
    public interface IUserSettingsService
    {
        UserSettings GetSettings();

        void UpdateUserSettings(UserSettings userSettings);
    }
}
