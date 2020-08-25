using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using Cysteel.Buffs;

namespace Cysteel.Projectiles
{
    public class SkyCrystal : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.damage = 1000000;
            projectile.width = 32;
            projectile.height = 22;
            projectile.friendly = true;
            projectile.penetrate = 5;
            projectile.hostile = false;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(ModContent.BuffType<SinglaicInferno>(), 600);
        }

        public override void AI()
        {
            projectile.rotation += 2f;
            projectile.localAI[0] += 1f;
            if (projectile.localAI[0] > 60) //projectile time left before disappears
            {
                projectile.Kill();

            }
            //    if (Main.rand.NextBool(3))
            //    {
            //        Vector2 dustVel = projectile.velocity;
            //        if (dustVel != Vector2.Zero)
            //        {
            //            dustVel.Normalize();
            //        }
            //        int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Ice);
            //        Main.dust[dust].velocity -= 1.2f * dustVel;
            //    }
            //    Lighting.AddLight(projectile.Center, Color.White.ToVector3() * 0.78f);

            //}
        }
    }
}