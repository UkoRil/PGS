using purgaytorymemebersuggestions.Content.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Weapons
{
	public class Enridemonaxe : ModItem
	{
		public override void SetDefaults() {
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useAnimation = 20;
			Item.useTime = 20;
			Item.damage = 72;
			Item.knockBack = 2.5f;
			Item.width = 50;
			Item.height = 50;
			Item.scale = 2f;
			Item.UseSound = SoundID.Item69;
			Item.rare = ItemRarityID.Pink;
			Item.value = Item.buyPrice(gold: 70);
			Item.DamageType = DamageClass.Melee;
			Item.shoot = ModContent.ProjectileType<Enridemonaxeproj>();
			Item.noMelee = true;
			Item.shootsEveryUse = true;
			Item.autoReuse = true;
		}
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			float adjustedItemScale = player.GetAdjustedItemScale(Item);
			Projectile.NewProjectile(source, player.MountedCenter, new Vector2(player.direction, 0f), type, damage, knockback, player.whoAmI, player.direction * player.gravDir, player.itemAnimationMax, adjustedItemScale);
			NetMessage.SendData(MessageID.PlayerControls, -1, -1, null, player.whoAmI);
			return base.Shoot(player, source, position, velocity, type, damage, knockback);
		}
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.HallowedBar, 30)
				.AddIngredient(ItemID.SoulofMight, 15)
				.AddIngredient(ItemID.SoulofFright, 15)
				.AddIngredient(ItemID.SoulofSight, 15)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}