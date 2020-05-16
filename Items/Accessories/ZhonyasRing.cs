using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;
using Tonymate.Buffs;
using Tonymate.Sounds;
using System.Diagnostics;

namespace Tonymate.Items.Accessories
{
    public class ZhonyasRing : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("20 mana " +
                "\nLiterally Zhonyas (120s)");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.defense = 5;
            item.accessory = true;
            item.rare = ItemRarityID.Yellow;
            item.value = Item.sellPrice(silver: 60);
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 20;

            TonymatePlayer modPlayer = player.GetModPlayer<TonymatePlayer>();
            modPlayer.StasisEffect(hideVisual);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Stopwatch, 1);
            recipe.AddIngredient(ItemID.GoldWatch, 1);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddIngredient(ItemID.Diamond, 1);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this); 
            recipe.AddRecipe(); 
        }
    }
}