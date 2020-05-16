using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Tonymate.Projectiles
{
    public class ZhonyaProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stasis");
        }

        public override void SetDefaults()
        {
            projectile.width = 56;
            projectile.height = 56;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 18000;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }

        public override bool CanDamage()
        {
            return false;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            TonymatePlayer modPlayer = player.GetModPlayer<TonymatePlayer>();

            if (player.dead)
            {
                modPlayer.zhonyaImg = false;
            }

            if (!(modPlayer.zhonyaImg))
            {
                projectile.Kill();
                return;
            }

            projectile.position.X = Main.player[projectile.owner].Center.X - projectile.width / 2;
            projectile.position.Y = Main.player[projectile.owner].Center.Y - projectile.height / 2;
        }
    }
}
