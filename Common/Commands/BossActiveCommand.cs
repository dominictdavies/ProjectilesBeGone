using Microsoft.Xna.Framework;
using ProjectilesBeGone.Common.Projectiles;
using Terraria.ModLoader;

namespace ProjectilesBeGone.Common.Commands
{
    public class BossActiveCommand : ModCommand
    {
        public override CommandType Type
            => CommandType.Chat;

        public override string Command
            => "bossActive";

        public override string Usage
            => "/bossActive";

        public override string Description
            => "Toggles this mod to only be active during boss fights.";

        public override void Action(CommandCaller caller, string input, string[] args)
        {
            ProjectileVisibility.BossActive = !ProjectileVisibility.BossActive;
            caller.Reply(ProjectileVisibility.BossActive ? "Now only active during boss fights." : "Now active at all times.", Color.Green);
        }
    }
}
