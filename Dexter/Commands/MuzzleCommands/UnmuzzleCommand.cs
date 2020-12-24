﻿using Dexter.Attributes.Methods;
using Dexter.Enums;
using Dexter.Extensions;
using Discord;
using Discord.Commands;
using Discord.Net;
using System.Threading.Tasks;

namespace Dexter.Commands {

    public partial class MuzzleCommands {

        [Command("unmuzzle")]
        [Summary("Unmuzzles the specified user.")]
        [RequireModerator]

        public async Task UnmuzzleCommand (IGuildUser User) {
            await Unmuzzle(User);

            EmbedBuilder Builder = BuildEmbed(EmojiEnum.Love)
                .WithTitle($"Unmuzzled {User.Username}.")
                .WithDescription($"{User.Username} has successfully had their muzzle removed from them. Make sure to fed them with lots of pats! <3")
                .WithCurrentTimestamp();

            try {
                await BuildEmbed(EmojiEnum.Love)
                    .WithTitle("You've Been Un-Muzzled!")
                    .WithDescription($"You have successfully been unmuzzled from **{Context.Guild.Name}**. Have a good one! <3")
                    .WithCurrentTimestamp()
                    .SendEmbed(await User.GetOrCreateDMChannelAsync());

                Builder.AddField("Success", "The DM was successfully sent!");
            } catch (HttpException) {
                Builder.AddField("Failed", "This fluff may have either blocked DMs from the server or me!");
            }

            await Builder.SendEmbed(Context.Channel);
        }

    }

}