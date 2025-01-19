using Microsoft.Xna.Framework;
using purgaytorymemebersuggestions.Content.Dusts;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Weapons
{
    public class ItallianoDePizzaSword : ModItem
    {
        public override void SetDefaults() {
            Item.width = 40;
            Item.height = 40;
            Item.scale = 2f;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 35;
            Item.knockBack = 1;
            Item.crit = 15;

            Item.value = Item.sellPrice(gold:30);
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item1;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox) {
            if (Main.rand.NextBool(3)) {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Pizzadrops>());
            }
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame) {
            player.itemLocation.X += player.direction * -10f;
            player.itemLocation.Y += 25f;
        }

        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
            target.AddBuff(BuffID.OnFire, 60);
        }
    }
}
