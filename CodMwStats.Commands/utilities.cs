using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CodMwStats.ApiWrapper;
using CodMwStats.ApiWrapper.Models;
using Discord;
using Discord.Commands;
using Newtonsoft.Json;

namespace CodMwStats.Commands
{
    public class Utilities : ModuleBase<SocketCommandContext>
    {
        [Command("Ping")]
        public async Task Ping()
        {
            await Context.Channel.SendMessageAsync("Pong");
        }

        [Command("invite")]
        public async Task Invite()
        {
            await Context.Channel.SendMessageAsync(
                "https://discordapp.com/oauth2/authorize?client_id=695738324425375805&scope=bot&permissions=388161");
        }
    }
}
