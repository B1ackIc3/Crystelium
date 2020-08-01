using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace Cysteel
{
    class Cysteel : Mod
    {
        public Cysteel()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
            };
        }

        public override void Load()
        {
            if (!Main.dedServ) // do not run this code on the server
            {
                //AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CoagMusicBox"), ItemType("CoagMusicBox"), TileType("CoagMusicBox"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/CursoryMusicBox"), ItemType("CursoryMusicBox"), TileType("CursoryMusicBox"));
            }
        }
        public override void Close()
        {
            // Fix a tModLoader bug.
            var slots = new int[] {
                //GetSoundSlot(SoundType.Music, "Sounds/Music/CoagMusicBox"),
                GetSoundSlot(SoundType.Music, "Sounds/Music/CursoryMusicBox"),
            };
            foreach (var slot in slots) // Other mods crashing during loading can leave Main.music in a weird state.
            {
                if (Main.music.IndexInRange(slot) && Main.music[slot]?.IsPlaying == true)
                {
                    Main.music[slot].Stop(Microsoft.Xna.Framework.Audio.AudioStopOptions.Immediate);
                }
            }

            base.Close();
        }
    }
}
    




