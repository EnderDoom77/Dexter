﻿using Dexter.Configurations;
using Dexter.Abstractions;
using Dexter.Services;

namespace Dexter.Commands {
    public partial class UtilityCommands : ModuleD {

        private readonly LoggingService LoggingService;

        private readonly BotConfiguration BotConfiguration;

        public UtilityCommands(BotConfiguration _BotConfiguration, LoggingService _LoggingService) {
            BotConfiguration = _BotConfiguration;
            LoggingService = _LoggingService;
        }

    }
}
