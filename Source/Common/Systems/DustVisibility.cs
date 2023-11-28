using Terraria;
using Terraria.ModLoader;

namespace ProjectilesBeGone.Source.Common.Systems
{
    public class DustVisibility : ModSystem
    {
        public static bool HideDust { get; set; } = true;

        public override void PreUpdateDusts()
        {
            for (int i = 0; i < Main.maxDust; i++) {
                Dust dust = Main.dust[i];
                if (dust.active && HideDust) {
                    Main.dust[i].scale = 0f;
                }
            }
        }
    }
}
