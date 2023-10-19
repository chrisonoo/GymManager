using GymManager.Application.Common.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Services;
public class AppSettingsService : IAppSettingsService
{
    private Dictionary<string, string> _appSettings = new Dictionary<string, string>();
    private static SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

    private async Task Wait()
    {
        await _semaphore.WaitAsync();
    }

    private void Release()
    {
        _semaphore.Release();
    }

    public async Task<string> Get(string key)
    {
        try
        {
            await Wait();
            return _appSettings[key];
        }
        finally
        {
            Release();
        }
    }

    public async Task Update(IApplicationDbContext context)
    {
        try
        {
            await Wait();

            _appSettings.Clear();

            var settingsPositions = await context
                .SettingsPositions
                .AsNoTracking()
                .ToListAsync();

            foreach(var position in settingsPositions)
                _appSettings.Add(position.Key, position.Value);
        }
        finally
        {
            Release();
        }
    }
}
