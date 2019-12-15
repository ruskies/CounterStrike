﻿using Terraria.ID;

namespace CounterStrike.Guns.Rifles.AWP
{
    public class AWP : CSGun
    {
        public AWP() : base("AWP", 
            "High risk and high reward, the infamous AWP is recognizable\n" + 
            "by its signature report and one-shot, one-kill policy.",
            96, 26, GunDefinitionsManager.Instance.AWP)
        {
        }


        public override void SetDefaults()
        {
            base.SetDefaults();

            item.shoot = ProjectileID.BulletHighVelocity;
            item.shootSpeed = 24f;
        }
    }
}