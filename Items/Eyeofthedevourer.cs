using Cysteel.Projectiles;
using Cysteel.Sounds.Item;
using Cysteel.Items.Placeable;
using Cysteel.Tiles;
using Terraria.DataStructures;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Cysteel.Items
{
	public class Eyeofthedevourer : ModItem
    {

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eye of the Devourer");
			Tooltip.SetDefault("50% increased additive damage" +
							   "\n50% increased speed" +
							   "\nIncreased life regen" +
							   "\n+1000 Max Life" +
                               "\n+200 Max Mana " +
							   "\n+20 Armor Penetration");
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
			item.rare = ItemRarityID.Expert;
		}


		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage += 0.50f;
			player.endurance += 0.50f;
			player.maxRunSpeed += 10f;
			player.statLifeMax2 += 1000;
			player.statManaMax2 += 200;
			player.armorPenetration += 20;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Placeable.CytoxicSteelBar>(), 35);
			recipe.AddIngredient(ItemType<Items.HeavyMetalCore>(), 1);
			recipe.AddIngredient(ItemType<Items.MythicalMetalCore>(), 1);
			recipe.AddIngredient(ItemType<Items.CollapsedSoul>(), 1);
			recipe.AddIngredient(ItemType<Items.LunarLens>(), 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}