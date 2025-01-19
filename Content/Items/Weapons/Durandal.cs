using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Weapons
{
	public class Durandal : ModItem
	{
		public override void SetDefaults() {
			Item.width = 70;
			Item.height = 70;
      Item.scale = 3f;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 15;
			Item.useAnimation = 20;
			Item.autoReuse = true;
			Item.DamageType = DamageClass.Melee;
			Item.damage = 80;
			Item.knockBack = 6;
			Item.crit = 6;
			Item.value = Item.buyPrice(gold: 90);
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
		}
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
			target.AddBuff(BuffID.BrokenArmor, 60);
		}

    public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
				recipe.AddIngredient(ItemID. MythrilBar, 25);
				recipe.AddIngredient(ItemID. SoulofLight, 15);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.Register();
		}
	}
}
