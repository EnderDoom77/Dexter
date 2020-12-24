﻿using Dexter.Attributes.Methods;
using Discord.Commands;
using System.Threading.Tasks;

namespace Dexter.Commands {

    public partial class MuzzleCommands {

        [Command("roulette")]
        [Summary("Test your luck with a 1 in 4 chance you get muzzled!")]
        [Alias("testmyluck")]
        [CommandCooldown(45)]

        public async Task RouletteCommand() {
            if (Random.Next(4) == 1)
                await MuzzleCommand(Context.Guild.GetUser(Context.User.Id));
            else
                await Context.Channel.SendMessageAsync("You missed it - lucky you! <3");
        }

    }

}