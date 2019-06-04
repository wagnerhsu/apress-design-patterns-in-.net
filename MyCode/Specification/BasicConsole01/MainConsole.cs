using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsole01
{
    public class MainConsole
    {
        ILogger<MainConsole> _logger;
        public MainConsole(ILogger<MainConsole> logger)
        {
            _logger = logger;
        }
        public void DoWork()
        {
            
        }
    }
}
