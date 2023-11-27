using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ReviveMod.Source.Common.Commands
{
    public class ProjModeCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;

        public override string Command
            => "projMode";

        public override string Usage
            => "/projMode mode" +
            "\n 0 - All" +
            "\n 1 - Hostile and your own" +
            "\n 2 - Hostile" +
            "\n 3 - None";

        public override string Description
            => "Sets what projectiles will be visible." +
            "\n 0 - All" +
            "\n 1 - Hostile and your own" +
            "\n 2 - Hostile" +
            "\n 3 - None";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (caller.Player.whoAmI != 0) {
                throw new UsageException("Only the host may use this command.");
            }
        }
    }
}
