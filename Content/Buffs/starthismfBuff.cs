using Terraria;
using Terraria.ModLoader;
using purgaytorymemebersuggestions.Content.Projectiles.Minions;

namespace purgaytorymemebersuggestions.Content.Buffs
{
public class starthismfBuff : ModBuff
	{
		public override void SetStaticDefaults() {
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[ModContent.ProjectileType<starthismfMinion>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			}
			else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}