using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace purgaytorymemebersuggestions.Content.Items.Materials
{
    public class ShikoAntlersNPCDrop : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Deerclops)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ShikoAntlers>(), 25, 1, 1));
            }
        }
    }
}