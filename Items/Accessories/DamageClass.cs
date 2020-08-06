using Terraria;
using Terraria.ModLoader;
using Cysteel.Items.Acessories;
namespace Cysteel.Items.Acessories
{
	// This class stores necessary player info for our custom damage class, such as damage multipliers and additions to knockback and crit.
	public class DamageClass : ModPlayer
	{
		public static DamageClass ModPlayer(Player player)
		{
			return player.GetModPlayer<DamageClass>();
		}

		// Vanilla only really has damage multipliers in code
		// And crit and knockback is usually just added to
		// As a modder, you could make separate variables for multipliers and simple addition bonuses
		public float ModDamageAdd;
		public float ModDamageMult = 1f;
		public float ModKnockback;
		public int ModCrit;

		public override void ResetEffects()
		{
			ResetVariables();
		}

		public override void UpdateDead()
		{
			ResetVariables();
		}

		private void ResetVariables()
		{
			ModDamageAdd = 0f;
			ModDamageMult = 1f;
			ModKnockback = 0f;
			ModCrit = 0;
		}
	}
}