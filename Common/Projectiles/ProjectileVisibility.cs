using Terraria;
using Terraria.ModLoader;

namespace ProjectilesBeGone.Common.Projectiles
{
    public class ProjectileVisibility : GlobalProjectile
    {
        public enum ProjMode : byte
        {
            All,
            HostileAndYours,
            Hostile,
            None
        }

        public static ProjMode Mode { get; set; } = ProjMode.HostileAndYours;

        public override void AI(Projectile projectile)
        {
            ModLoader.TryGetMod("ReviveMod", out Mod reviveMod);
            reviveMod.TryFind("ReviveAura", out ModProjectile reviveAura);
            if (projectile.type == reviveAura.Type) {
                return;
            }

            if (Mode == ProjMode.None ||
               Mode == ProjMode.Hostile && !projectile.hostile ||
               Mode == ProjMode.HostileAndYours && !projectile.hostile && projectile.owner != Main.myPlayer) {
                projectile.hide = true;
            }
        }
    }
}
