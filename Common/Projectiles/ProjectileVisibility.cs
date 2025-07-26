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
        public static bool BossActive { get; set; } = true;

        private static int? _reviveAuraType;
        private static bool IsReviveAura(int projectileType)
        {
            if (_reviveAuraType is null &&
                ModLoader.TryGetMod("ReviveMod", out Mod mod) &&
                mod.TryFind("ReviveAura", out ModProjectile aura)) {
                _reviveAuraType = aura.Type;
            }
            return _reviveAuraType is int auraType && projectileType == auraType;
        }

        public override void AI(Projectile projectile)
        {
            if ((BossActive && !Main.CurrentFrameFlags.AnyActiveBossNPC) || IsReviveAura(projectile.type)) {
                return;
            }

            if ((Mode == ProjMode.None) ||
                (Mode == ProjMode.Hostile && !projectile.hostile) ||
                (Mode == ProjMode.HostileAndYours && !projectile.hostile && projectile.owner != Main.myPlayer)) {
                projectile.hide = true;
            }
        }
    }
}
