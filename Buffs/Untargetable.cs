using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Tonymate.Buffs
{
    public class Untargetable : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Stasis");
            Description.SetDefault("You become untargetable for 2.5 seconds");
            Main.buffNoSave[Type] = true;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<TonymatePlayer>().zhonyaImg = true;
            player.controlJump = false;
            player.controlDown = false;
            player.controlLeft = false;
            player.controlRight = false;
            player.controlUp = false;
            player.controlUseItem = false;
            player.controlUseTile = false;
            player.controlThrow = false;
            player.controlMount = false;
            player.velocity = player.oldVelocity;
            player.position = player.oldPosition;
        }
    }
}