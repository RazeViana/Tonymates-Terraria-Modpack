using Terraria;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Tonymate
{


    public class Tonymate : Mod
    {
        public static ModHotKey Zhonyas;

        public override void Load()
        {
            Zhonyas = RegisterHotKey("Zhonyas", "Z");
        }

        public override void Unload()
        {
            Zhonyas = null;
        }
    }
}