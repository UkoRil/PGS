using Terraria;
using purgaytorymemebersuggestions.Content.Items.Tools;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace purgaytorymemebersuggestions.Content.Items.Accessories
{
    public class Jokersshoveldrop : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Plantera)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Jokersshovel>(), 1));
            }
        }
    }
}