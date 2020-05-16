using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonymate.Buffs;
using Tonymate.Items;
using Tonymate.NPCs;
using Tonymate.Sounds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;
using Tonymate.Projectiles;

namespace Tonymate
{
    public partial class TonymatePlayer : ModPlayer
    {
        //Accessories
        public bool ZhonyasRing;
        public bool zhonyaImg;
        private int zhonyaCD = 0;
        private int ZhonyaHP;

        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (Tonymate.Zhonyas.JustPressed && ZhonyasRing && zhonyaCD == 0)
            {
                player.AddBuff(ModContent.BuffType<Untargetable>(), 180); //3seconds
                player.AddBuff(ModContent.BuffType<ZhonyaTimer>(), 7200); //7200 = 2mins
                zhonyaCD = 7200;
                ZhonyaHP = player.statLife;
                Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/Custom/Tinggg").WithVolume(1f), player.Center);
            }
        }

        public override void ResetEffects()
        {
            ZhonyasRing = false;
            zhonyaImg = false;
        }
        public override void PreUpdate()
        {
            if (ZhonyasRing && zhonyaCD > 0)
                zhonyaCD--;

            if (zhonyaImg)
            {
                player.immune = true;
                player.immuneTime = 2;
                player.hurtCooldowns[0] = 2;
                player.hurtCooldowns[1] = 2;

                if (player.statLife < ZhonyaHP)
                    player.statLife = ZhonyaHP;

                if (player.ownedProjectileCounts[ModContent.ProjectileType<ZhonyaProj>()] <= 0)
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, 0f, 0f, ModContent.ProjectileType<ZhonyaProj>(), 0, 0, Main.myPlayer);
            }
        }
    }
}
