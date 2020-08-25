using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Cysteel.Items.Acessories;

namespace Cysteel.Items
{
	public class CollapsedSoul : ModItem
{
	public override void SetStaticDefaults()
	{
		Tooltip.SetDefault("Just. Why?." +
			"\n10% increased additive damage" +
			"\n10% increased speed" +
			"\nIncreased life regen" +
			"\n+20 Max Life" +
			"\n+40 Max Mana");
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
		item.rare = ItemRarityID.Red;
	}
	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		player.allDamage += 0.10f;
		player.endurance += 0.10f;
		player.maxRunSpeed += 2.0f;
		player.statLifeMax2 += 20;
		player.statManaMax2 += 40;
		

	}

	public override void AddRecipes()
	{
		ModRecipe recipe = new ModRecipe(mod);
		recipe.AddIngredient(ItemID.SoulofLight, 15);
		recipe.AddIngredient(ItemID.SoulofNight, 15);
		recipe.AddIngredient(ItemID.SoulofFright, 15);
		recipe.AddIngredient(ItemID.SoulofMight, 15);
		recipe.AddIngredient(ItemID.SoulofSight, 15);
		recipe.AddIngredient(ItemID.SoulofFlight, 15);
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
		}
	}
}