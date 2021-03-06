﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.UI;

namespace CounterStrike.UserInterfaces.BuyMenu
{
    public class BuyLayer : GameInterfaceLayer
    {
        public BuyLayer(BuyMenuState state) : base("CounterStrike: Buy Menu", InterfaceScaleType.UI)
        {
            BuyUIState = state;
            BuyUIState.Activate();
            Interface = new UserInterface();
            Interface.SetState(BuyUIState);
        }


        public void Update(GameTime gameTime)
        {
            if (BuyUIState != null && BuyUIState.Visible)
            {
                BuyUIState?.Update(gameTime);
                Interface.Update(gameTime);
            }
        }

        protected override bool DrawSelf()
        {
            if(BuyUIState != null && BuyUIState.Visible)
                BuyUIState.Draw(Main.spriteBatch);

            return true;
        }


        public BuyMenuState BuyUIState { get; }

        public UserInterface Interface { get; }
    }
}
