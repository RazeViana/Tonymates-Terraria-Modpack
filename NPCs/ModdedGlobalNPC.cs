using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Tonymate.Items;
using Tonymate.Buffs;
using Tonymate.Items.Accessories;

namespace Tonymate.NPCs
{
    public class ModdedGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            //if (npc.type == NPCID.EyeofCthulhu && Main.rand.Next(10) == 0)
            //{
            //    Item.NewItem(npc.Hitbox, ModContent.ItemType<ZhonyasRing>());
            //}
        }
    }
}