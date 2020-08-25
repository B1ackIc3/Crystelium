using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Cysteel.Items.Acessories;

namespace Cysteel.Items
{
	public class HeavyMetalCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The combination of all pre hardmode ores. 'These shouldnt all exist in one place'" +
				"\n5% increased additive damage" +
				"\n5% increased speed" +
				"\nIncreased life regen" +
				"\n+5 Max Life" +
				"\n+20 Max Mana" +
				"\n+1 Armor Penetration");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 100;
			item.accessory = true;
			item.defense = 5;
			item.lifeRegen += 5;
			item.rare = ItemRarityID.Orange;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += 0.05f;
			player.endurance += 0.05f;
			player.maxRunSpeed += 1.5f;
			player.statLifeMax2 += 5;
			player.statManaMax2 += 20;
			player.armorPenetration += 1;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 10);
			recipe.AddIngredient(ItemID.TinBar, 10);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(ItemID.TungstenBar, 10);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddIngredient(ItemID.DemoniteBar, 10);
			recipe.AddIngredient(ItemID.MeteoriteBar, 10);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Hellforge);
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