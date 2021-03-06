﻿using System;
using CounterStrike.Players;

namespace CounterStrike.Ammo
{
    public class StandardExtraClipRule : ExtraClipRule
    {
        public StandardExtraClipRule(string unlocalizedName, Predicate<CSPlayer> requirement, int add, float mult, int flat) : base(unlocalizedName)
        {
            Requirement = requirement;

            Add = add;
            Mult = mult;
            Flat = flat;
        }


        public override bool MeetsRequirements(CSPlayer csPlayer) => Requirement(csPlayer);

        public override void ExtraClipCount(ref int add, ref float mult, ref int flat)
        {
            add += Add;
            mult += Mult;
            flat += Flat;
        }


        public Predicate<CSPlayer> Requirement { get; }

        public int Add { get; }

        public float Mult { get; }

        public int Flat { get; }
    }
}