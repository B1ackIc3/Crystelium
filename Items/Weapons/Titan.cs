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
	public class Titan : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titan");
			Tooltip.SetDefault("Titan, the sword born to rival the power of Galacine its self.");
		}
		public override void SetDefaults()
		{
			item.damage = 100000;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 1;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 300;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileType<SkyCrystal>();
			item.shootSpeed = 10f;
			item.autoReuse = true;
			
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles =  20+ Main.rand.Next(1); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(5);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 0f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<Items.Placeable.CytoxicSteelBar>(), 35);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.FallenStar, 100);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
