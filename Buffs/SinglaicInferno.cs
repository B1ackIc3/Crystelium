using Terraria;
using Terraria.ModLoader;
using Cysteel.NPCs;

namespace Cysteel.Buffs
{
	// Ethereal Flames is an example of a buff that causes constant loss of life.
	// See ExamplePlayer.UpdateBadLifeRegen and ExampleGlobalNPC.UpdateLifeRegen for more information.
	public class SinglaicInferno : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Singlaic Inferno");
			Description.SetDefault("You are being drained of your life. Fast.");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.GetModPlayer<CysteelPlayer>().sInferno = true;
		}

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<ExampleGlobalNPC>().sInferno = true;
        }
    }
}