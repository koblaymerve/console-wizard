using Console.Wizard.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console.Wizard.Service
{
    public class WizardService : IHostedService, IDisposable
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _config;
        public WizardService(ILogger<WizardService> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void Dispose()
        {
            _logger.LogInformation("Disposing....");
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting wizard: " + _config.GetValue<string>("WizardName"));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopping wizard.");
            return Task.CompletedTask;
        }
    }
}
