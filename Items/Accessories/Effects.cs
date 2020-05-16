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
using Tonymate.Items.Accessories;

namespace Tonymate
{
    public partial class TonymatePlayer
    {
        public void StasisEffect(bool hideVisual)
        {
            ZhonyasRing = true;
        }
    }
}
