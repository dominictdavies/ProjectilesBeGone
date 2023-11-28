using Microsoft.Xna.Framework;
using ProjectilesBeGone.Common.Systems;
using Terraria.ModLoader;

namespace ProjectilesBeGone.Common.Commands
{
    public class HideDustCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;

        public override string Command
            => "hideDust";

        public override string Usage
            => "/hideDust";

        public override string Description
            => "Toggles the visibility of dust.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            DustVisibility.HideDust = !DustVisibility.HideDust;
            caller.Reply(DustVisibility.HideDust ? "Dust is now hidden." : "Dust is no longer hidden.", Color.Green);
        }
    }
}
