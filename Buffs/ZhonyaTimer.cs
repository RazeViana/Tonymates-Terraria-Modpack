using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Tonymate.Buffs
{
    public class ZhonyaTimer : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Tonymate's Modpack");
            Description.SetDefault("Zhonyas Ring is on cooldown");
        }

        public override void Update(Player player, ref int buffIndex)
        {

        }
    }
}