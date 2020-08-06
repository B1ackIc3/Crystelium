using Cysteel.Projectiles;
using Cysteel.Tiles;
using Terraria.DataStructures;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Cysteel.Items.Weapons
{
    public class Galacine : ModItem
    {
        public static Color OverrideColor = new Color(155, 79, 150);

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galacine");
            Tooltip.SetDefault("Galacine, the sword birthed with the universe it's self.");
             //Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(1, 12));
            //ItemID.Sets.AnimatesAsSoul[item.type] = true;
            //ItemID.Sets.ItemIconPulse[item.type] = false;
        }
        
        public override void SetDefaults()
        {
            item.damage = 10000;
            item.channel = true;
            item.shootSpeed = 70f;
            item.shoot = ProjectileType<GalacineHoldout>();
            item.noMelee = false;
            item.magic = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 1;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 60;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item4;
            item.autoReuse = true;
            item.crit = 100;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3 + Main.rand.Next(1); // 3, 4, or 5 shots
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
            recipe.AddIngredient(ItemID.LunarBar, 45);
            recipe.AddIngredient(ItemID.FragmentNebula, 10);
            recipe.AddIngredient(ItemID.LastPrism, 1);
            recipe.AddIngredient(ItemID.FallenStar, 100);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


        public override bool AltFunctionUse(Player player)
        {

            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.shootSpeed = 10f;
                item.useStyle = 5;
                item.useTime = 2;
                item.useAnimation = 20;
                item.shoot = ProjectileType<SkyCrystal>();
            }
            else
            {
                item.shootSpeed = 90;
                item.useStyle = ItemUseStyleID.HoldingOut;
                item.useTime = 1;
                item.useAnimation = 40;
                item.shoot = ProjectileType<GalacineHoldout>();
            }
            return base.CanUseItem(player);
        }
    }
}

