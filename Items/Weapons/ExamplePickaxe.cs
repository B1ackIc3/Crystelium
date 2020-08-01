using Terraria.ID;
using Terraria.ModLoader;

namespace Cysteel.Items.Weapons
{
	public class ExamplePickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TestPick");
			Tooltip.SetDefault("Shit.");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.pick = 220;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
