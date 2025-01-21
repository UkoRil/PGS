using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace purgaytorymemebersuggestions.Content.Buffs
{
  public class Boreddebuff : ModBuff
  {
    public override void SetStaticDefaults()
    {
      Main.debuff[Type] = true;
      Main.buffNoSave[Type] = true;
      Main.buffNoTimeDisplay[Type] = true;
    }
    
    public override void Update(Player player, ref int buffIndex)
    {
      if (player.HasBuff(ModContent.BuffType<Boreddebuff>()))
      {
        player.moveSpeed -= 0.25f;
      }
    }
  }

  public class BoreddebuffPlayer : ModPlayer
  {
    private const int StandStillTimeThreshold = 2000;
    private Vector2 lastPosition;
    private int standStillTime;

    public override void Initialize()
    {
      lastPosition = Player.position;
      standStillTime = 0;
    }

    public override void PostUpdate()
    {
      if (Player.position == lastPosition)
      {
        standStillTime++;
        if (standStillTime >= StandStillTimeThreshold)
        {
          Player.AddBuff(ModContent.BuffType<Boreddebuff>(), 2400);
        }
      }
      else
      {
        standStillTime = 0;
      }

      lastPosition = Player.position;
    }
  }
}