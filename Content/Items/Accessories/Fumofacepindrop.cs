using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Accessories
{
  public class MoonLordDrop : GlobalNPC
  {
    public override void OnKill(NPC npc)
    {
      if (npc.type == NPCID.MoonLordCore)
      {
        if (Main.rand.NextFloat() < 0.5f)
        {
          Item.NewItem(npc.GetSource_Loot(), npc.getRect(), ModContent.ItemType<Fumofacepin>());
        }
      }
    }
  }
}