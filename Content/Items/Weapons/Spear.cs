using purgaytorymemebersuggestions.Content.Projectiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using purgaytorymemebersuggestions.Content.Items.Materials;

namespace purgaytorymemebersuggestions.Content.Items.Weapons
{
	public class Spear : ModItem
	{
		public override void SetStaticDefaults() {
			ItemID.Sets.SkipsInitialUseSound[Item.type] = true;
			ItemID.Sets.Spears[Item.type] = true;
		}
		
		public override void SetDefaults(){
			
			Item.rare = ItemRarityID.Pink;
			Item.value = Item.sellPrice(gold: 90);
			
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 50;
			Item.useTime = 50;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
			
			Item.damage = 170;
			Item.knockBack = 5;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.Melee;
			Item.noMelee = true;
			
			Item.shootSpeed = 2;
			Item.shoot = ModContent.ProjectileType<SpearProjectile>();
		}
		
		public override bool CanUseItem(Player player) {
			return player.ownedProjectileCounts[Item.shoot] < 1;
		}
		
		public override bool? UseItem(Player player) {
			if (!Main.dedServ && Item.UseSound.HasValue) {
				SoundEngine.PlaySound(Item.UseSound.Value, player.Center);
			}
			
			return null;
		}
		
		public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<ShikoAntlers>(), 1);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
	    recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 10);
	    recipe.AddIngredient(ItemID.SoulofMight, 10);
	    recipe.AddIngredient(ItemID.SoulofFright, 10);
            recipe.AddIngredient(ItemID.CursedFlame, 10);
            recipe.AddIngredient(ItemID.DarkLance, 1);
	    recipe.AddIngredient(ItemID.HallowedBar, 30);
            recipe.AddIngredient(ItemID.MechanicalWheelPiece, 1);
	    recipe.AddIngredient(ItemID.MechanicalWagonPiece, 1);
	    recipe.AddIngredient(ItemID.MechanicalBatteryPiece, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
		}
	}
}	