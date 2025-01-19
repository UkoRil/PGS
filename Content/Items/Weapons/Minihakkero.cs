using purgaytorymemebersuggestions.Content.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Weapons
{
	public class Minihakkero: ModItem
	{
		public static Color OverrideColor = new(122, 173, 255);

		public override void SetDefaults() {

			Item.CloneDefaults(ItemID.LastPrism);
			Item.mana = 50;
			Item.damage = 70;
			Item.shoot = ModContent.ProjectileType<Minihakkeroprojhold>();
			Item.shootSpeed = 20f;

			Item.color = OverrideColor;
			Item.rare = ItemRarityID.Red;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
				recipe.AddIngredient(ItemID. LunarBar, 15);
				recipe.AddIngredient(ItemID. LastPrism, 1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
		}

		public override bool CanUseItem(Player player) {
			return player.ownedProjectileCounts[ModContent.ProjectileType<Minihakkeroprojhold>()] <= 0;
		}
	}
}