using Terraria;
using Terraria.ModLoader;

namespace ProjectilesBeGone.Source.Common.Projectiles
{
    public class ProjectileAlpha : GlobalProjectile
    {
        public override void SetDefaults(Projectile entity)
        {
            entity.hide = true;
        }
    }
}
