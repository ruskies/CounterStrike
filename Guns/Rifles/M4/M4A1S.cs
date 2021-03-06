﻿using Microsoft.Xna.Framework;

namespace CounterStrike.Guns.Rifles.M4
{
    public class M4A1S : GunItem
    {
        public M4A1S() : base("M4A1-S",
            "With a smaller magazine than its unmuffled counterpart, the silenced\n" +
            "M4A1 provides quieter shots with less recoil and better accuracy.",
            88, 28, GunDefinitions.Instance.GetGeneric<M4A1SDefinition>())
        {
        }


        public override Vector2? HoldoutOffset() => new Vector2(-17, 5);
    }
}