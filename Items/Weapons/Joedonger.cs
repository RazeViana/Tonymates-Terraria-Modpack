using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tonymate.Items.Weapons
{
    public class Joedonger : ModItem 
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pussy Breath "+"\nExperimental");
        }

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 88; 
			item.useTime = 20; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 20; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
			item.knockBack = 6; // The force of knockback of the weapon. Maximum is 20
			item.value = Item.sellPrice(silver: 60); // The value of the weapon in copper coins
			item.rare = ItemRarityID.Pink; // The rarity of the weapon, from -1 to 13. You can also use ItemRarityID.TheColorRarity
			item.UseSound = SoundID.Item1; 
			item.autoReuse = true; 
			item.crit = 6; // The critical strike chance the weapon has. The player, by default, has 4 critical strike chance

			//The useStyle of the item. 
			//Use useStyle 1 for normal swinging or for throwing
			//use useStyle 2 for an item that drinks such as a potion,
			//use useStyle 3 to make the sword act like a shortsword
			//use useStyle 4 for use like a life crystal,
			//and use useStyle 5 for staffs or guns
			item.useStyle = ItemUseStyleID.SwingThrow; // 1 is the useStyle
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 60);
		}


	}
}
