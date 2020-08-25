using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Cysteel.Items.Acessories;

namespace Cysteel.Items
{
	public class LunarLens : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Lens of the lunar god. " +
                "\n'WOW this lens is opaque'" +
				"\n20% increased additive damage" +
				"\n20% increased speed" +
				"\nIncreased life regen" +
				"\n+65 Max Life" +
				"\n+80 Max Mana" +
				"\n+10 Armor Penetration");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 100;
			item.accessory = true;
			item.defense = 15;
			item.lifeRegen += 10;
			item.rare = ItemRarityID.Red;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += 0.2f;
			player.endurance += 0.2f;
			player.maxRunSpeed += 2.0f;
			player.statLifeMax2 += 65;
			player.statManaMax2 += 80;
			player.armorPenetration += 10;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddIngredient(ItemID.FragmentNebula, 10);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.FragmentStardust, 10);
			recipe.AddIngredient(ItemID.BlackLens, 5);
			recipe.AddIngredient(ItemID.Lens, 30);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);

			//{
			//	ModRecipe recipe = new ModRecipe(mod);
			//	recipe.AddIngredient(ItemID.CopperBar, 10);
			//	recipe.AddIngredient(ItemID.TinBar, 10);
			//	recipe.AddIngredient(ItemID.IronBar, 10);
			//	recipe.AddIngredient(ItemID.LeadBar, 10);
			//	recipe.AddIngredient(ItemID.SilverBar, 10);
			//	recipe.AddIngredient(ItemID.TungstenBar, 10);
			//	recipe.AddIngredient(ItemID.GoldBar, 10);
			//	recipe.AddIngredient(ItemID.PlatinumBar, 10);
			//	recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			//	recipe.AddIngredient(ItemID.HellstoneBar, 10);
			//	recipe.AddTile(TileID.Hellforge);
			//	recipe.SetResult(this);
			//	recipe.AddRecipe();
			//	recipe = new ModRecipe(mod);
			//}
		}
	}
}