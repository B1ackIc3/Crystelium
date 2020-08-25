using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Cysteel.Items.Acessories;

namespace Cysteel.Items
{
	public class MythicalMetalCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The combination of all hardmode ores. 'These absolutly shouldnt all exist in one place'" +
				"\n15% increased additive damage" +
				"\n15% increased speed" +
				"\nIncreased life regen" +
				"\n+35 Max Life" +
				"\n+60 Max Mana" +
				"\n+5 Armor Penetration");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 100;
			item.accessory = true;
			item.defense = 10;
			item.lifeRegen += 5;
			item.rare = ItemRarityID.Lime;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += 0.15f;
			player.endurance += 0.15f;
			player.maxRunSpeed += 1.5f;
			player.statLifeMax2 +=35;
			player.statManaMax2 += 60;
			player.armorPenetration += 5;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddIngredient(ItemID.PalladiumBar, 10);
			recipe.AddIngredient(ItemID.MythrilBar, 10);
			recipe.AddIngredient(ItemID.OrichalcumBar, 10);
			recipe.AddIngredient(ItemID.AdamantiteBar, 10);
			recipe.AddIngredient(ItemID.TitaniumBar, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
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