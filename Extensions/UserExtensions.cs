﻿using Dexter.Configurations;
using Dexter.Enums;
using Discord;
using System;
using System.Linq;

namespace Dexter.Extensions {
    /// <summary>
    /// The User Extensions class offers a variety of different extensions that can be applied to user to return specific attributes.
    /// </summary>
    public static class UserExtensions {

        /// <summary>
        /// The GetPermissionLevel returns the highest permission the user has access to for commands.
        /// </summary>
        /// <param name="User">The GuildUser of which you want to get the permission level of.</param>
        /// <param name="Configuration">The instance of the bot configuration which is used to get the role ID for roles.</param>
        /// <returns>What permission level the user has, in the form from the PermissionLevel enum.</returns>
        public static PermissionLevel GetPermissionLevel(this IGuildUser User, BotConfiguration Configuration) {
            if (User.GuildPermissions.Has(GuildPermission.Administrator))
                return PermissionLevel.Administrator;

            if (User.RoleIds.Contains(Configuration.ModeratorRoleID))
                return PermissionLevel.Moderator;

            return PermissionLevel.Default;
        }

        /// <summary>
        /// The GetUserInformation method returns a string of the users username, followed by the discriminator, the mention and the ID.
        /// It is used as a standardized way throughout the bot to display information on a user.
        /// </summary>
        /// <param name="User">The user of which you want to create the standardized string of the user's information of.</param>
        /// <returns>A string which contains the user's username, discriminator, mention and ID.</returns>
        public static string GetUserInformation(this IUser User) {
            return $"{User.Username}#{User.Discriminator} ({User.Mention}) ({User.Id})";
        }

    }
}