using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Tools
{
    public class Jokersshovel : ModItem
	{
		public override void SetDefaults() {
			Item.damage = 40;
			Item.DamageType = DamageClass.Melee;
			Item.width = 60;
			Item.height = 60;
			Item.useTime = 6;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(gold: 90);
			Item.rare = ItemRarityID.Lime;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Item.pick = 220;
			Item.attackSpeedOnlyAffectsWeaponAnimation = true;
		}
  }
}