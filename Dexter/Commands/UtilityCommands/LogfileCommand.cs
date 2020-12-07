﻿using Dexter.Attributes.Methods;
using Discord.Commands;
using System.IO;
using System.Threading.Tasks;

namespace Dexter.Commands {

    public partial class UtilityCommands {

        [Command("logfile")]
        [Summary("Provides the logfile for the current instance of the bot.")]
        [Alias("log")]
        [RequireModerator]

        public async Task LogfileCommand() {
            if (!File.Exists(LoggingService.LogFile))
                throw new FileNotFoundException();

            await Context.Channel.SendFileAsync(LoggingService.LogFile);
        }

    }

}