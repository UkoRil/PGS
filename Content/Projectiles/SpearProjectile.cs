using purgaytorymemebersuggestions.Content.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Projectiles
{
	public class SpearProjectile : ModProjectile
	{
		protected virtual float HoldoutRangeMin => 35f;
		protected virtual float HoldoutRangeMax => 180f;

		public override void SetDefaults() {
			Projectile.CloneDefaults(ProjectileID.Spear); 
		}

		public override bool PreAI() {
			Player player = Main.player[Projectile.owner];
			int duration = player.itemAnimationMax;
			player.heldProj = Projectile.whoAmI; 

			
			if (Projectile.timeLeft > duration) {
				Projectile.timeLeft = duration;
			}

			Projectile.velocity = Vector2.Normalize(Projectile.velocity);

			float halfDuration = duration * 0.5f;
			float progress;

			
			if (Projectile.timeLeft < halfDuration) {
				progress = Projectile.timeLeft / halfDuration;
			}
			else {
				progress = (duration - Projectile.timeLeft) / halfDuration;
			}

			
			Projectile.Center = player.MountedCenter + Vector2.SmoothStep(Projectile.velocity * HoldoutRangeMin, Projectile.velocity * HoldoutRangeMax, progress);

		
			if (Projectile.spriteDirection == -1) {
				
				Projectile.rotation += MathHelper.ToRadians(45f);
			}
			else {
			
				Projectile.rotation += MathHelper.ToRadians(135f);
			}

			if (!Main.dedServ) {

				if (Main.rand.NextBool(3)) {
					Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, DustID.t_Martian, Projectile.velocity.X * 2f, Projectile.velocity.Y * 2f, Alpha: 128, Scale: 1.2f);
				}
				
				if (Main.rand.NextBool(3)) {
					Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<Sparkle>(), Projectile.velocity.X * 2f, Projectile.velocity.Y * 2f, Alpha: 128, Scale: 1.2f);
				}

				if (Main.rand.NextBool(4)) {
					Dust.NewDustDirect(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<Sparkle>(), Alpha: 128, Scale: 0.3f);
				}
			}

			return false;
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone) {
			target.AddBuff(BuffID.CursedInferno, 300);
			target.AddBuff(BuffID.Electrified, 300);
			target.AddBuff(BuffID.ShadowFlame, 300);
}
	}
}
