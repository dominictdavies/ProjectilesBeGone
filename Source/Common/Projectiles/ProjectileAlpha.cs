using Terraria;
using Terraria.ModLoader;

namespace ProjectilesBeGone.Source.Common.Projectiles
{
    public class ProjectileAlpha : GlobalProjectile
    {
        internal enum ProjMode : byte
        {
            All,
            HostileAndYours,
            Hostile,
            None
        }

        private static ProjMode mode = ProjMode.HostileAndYours;

        public override void AI(Projectile projectile)
        {
            if (mode == ProjMode.None ||
               (mode == ProjMode.Hostile && !projectile.hostile) ||
               (mode == ProjMode.HostileAndYours && !projectile.hostile && projectile.owner != Main.myPlayer)) {
                projectile.hide = true;
            }
        }
    }
}
