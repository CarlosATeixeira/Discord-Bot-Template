using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barista.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        public static SocketUserMessage message;

        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("Pong!");
        }

        [Command("help")]
        public async Task Help()
        {
            if(CurrentChannelId() == 897240255210594364)
            {
                await ReplyAsync("How can i help?");
            }
        }





        ulong CurrentChannelId()
        {
            return message.Channel.Id;
        }
    }
}
