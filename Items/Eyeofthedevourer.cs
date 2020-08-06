using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Cysteel.Items.Acessories;

namespace Cysteel.Items
{
	public class Eyeofthedevourer : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye of the Devourer");
			Tooltip.SetDefault("50% increased additive damage" +
							   "\n50% increased speed" +
							   "\nincreased life regen");
			//Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(1, 24));
			//ItemID.Sets.AnimatesAsSoul[item.type] = true;
			//ItemID.Sets.ItemIconPulse[item.type] = false;
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.accessory = true;
			item.defense = 25;
			item.lifeRegen += 50;
			item.value = 10000000;
			item.rare = ItemRarityID.Blue;
		}


		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += 0.50f;
			player.endurance += 0.50f;
			player.maxRunSpeed += 10f;
			
		}
	}
}