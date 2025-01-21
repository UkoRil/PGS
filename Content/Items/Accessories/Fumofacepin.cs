using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Accessories
{
  public class Fumofacepin : ModItem
  {
    public override void SetDefaults()
    {
      Item.width = 24;
      Item.height = 24;
      Item.accessory = true;
      Item.value = Item.sellPrice(gold: 54);
      Item.rare = ItemRarityID.Expert;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
      player.GetModPlayer<FumofacepinPlayer>().dodgeChance = true;
    }
  }

  public class FumofacepinPlayer : ModPlayer
  {
    public bool dodgeChance;

    public override void ResetEffects()
    {
      dodgeChance = false;
    }

    public override void UpdateDead()
    {
      dodgeChance = false;
    }

    public override void PostUpdateEquips()
    {
      if (dodgeChance)
      {
        if (Main.rand.NextFloat() < 0.9f)
        {
          Player.shadowDodge = true;
        }
      }
    }
  }
}