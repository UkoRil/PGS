using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Accessories
{
  public class Neuncells : ModItem
  {
    public override LocalizedText Tooltip => base.Tooltip;
    public override void SetDefaults() {
      Item.rare = ItemRarityID.Orange;
      Item.width = 40;
      Item.height = 40;
      Item.accessory = true;
    }
    public override void UpdateAccessory(Player player, bool hideVisual) {
      player.statDefense += 10;
      player.moveSpeed += 1f;

      if (player.HasBuff(BuffID.PotionSickness) || player.HasBuff(BuffID.Bleeding)) {
        player.lifeRegen += 4;
      } else {
        player.lifeRegen += 6;
      }
    }
  }
}