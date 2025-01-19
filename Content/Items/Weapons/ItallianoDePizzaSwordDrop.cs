using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace purgaytorymemebersuggestions.Content.Items.Weapons
{
    public class ItallianoDePizzaSwordDrop : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.WallofFlesh)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ItallianoDePizzaSword>(), 1));
            }
        }
    }
}