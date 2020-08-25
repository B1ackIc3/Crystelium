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
using Cysteel.Buffs;
using Cysteel.NPCs;

namespace Cysteel.Items.Weapons
{
	public class NebulaicNullity: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nebulaic Nullity");
			Tooltip.SetDefault("Abyss- oops");
		}
		public override void SetDefaults()
		{
			item.damage = 200;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 1;
			item.useAnimation = 1;
			item.pick = 500;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 600;
			item.value = 1000000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Placeable.CytoxicSteelBar>(), 15);
			recipe.AddIngredient(ItemID.VortexPickaxe, 1);
			recipe.AddIngredient(ItemID.NebulaPickaxe, 1);
			recipe.AddIngredient(ItemID.SolarFlarePickaxe, 1);
			recipe.AddIngredient(ItemID.StardustPickaxe, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 10);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.FragmentStardust, 10);
			recipe.AddIngredient(ItemID.CrystalShard, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
