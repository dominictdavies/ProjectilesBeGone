using Microsoft.Xna.Framework;
using ProjectilesBeGone.Source.Common.Projectiles;
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
            => "/projMode mode";

        public override string Description
            => "Sets what projectiles will be visible." +
            "\n 0 - All" +
            "\n 1 - Hostile and your own" +
            "\n 2 - Hostile" +
            "\n 3 - None";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            if (args.Length != 1) {
                throw new UsageException("Expected exactly 1 argument.");
            }

            if (!int.TryParse(args[0], out int modeIndex)) {
                throw new UsageException("Expected a number.");
            }

            ProjectileVisibility.Mode = (ProjectileVisibility.ProjMode)modeIndex;

            string reply = "Set projectile visibility to {0}.";
            if (modeIndex == 0) {
                reply = string.Format(reply, "all");
            } else if (modeIndex == 1) {
                reply = string.Format(reply, "hostile and your own");
            } else if (modeIndex == 2) {
                reply = string.Format(reply, "hostile");
            } else if (modeIndex == 3) {
                reply = string.Format(reply, "none");
            } else {
                throw new UsageException("Expected a number from 0 to 3.");
            }

            caller.Reply(reply, Color.Green);
        }
    }
}
