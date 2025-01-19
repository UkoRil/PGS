using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace purgaytorymemebersuggestions.Content.Items.Materials
{
    internal class ShikoAntlers : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.value = Item.buyPrice(gold: 15);  
            Item.maxStack = 1;
            Item.rare = ItemRarityID.Orange;
        }
    }
}
