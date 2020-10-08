﻿using CounterStrike.Guns;
using Microsoft.Xna.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;

namespace CounterStrike.UserInterfaces.BuyMenu
{
    public class MenuPanel : UIPanel
    {
        public MenuPanel()
        {
            MenuOptions = new List<MenuButton>();
        }

        public void PostInitialize()
        {
            this.Width.Set(700, 0);
            this.Height.Set(500, 0);
            this.HAlign = 0.5f;
            this.VAlign = 0.5f;
            this.BackgroundColor = Color.Black * 0.5f;

            int currentOption = 0;

            foreach(MenuButton button in MenuOptions)
            {
                button.Top.Set(5 + 42 * currentOption, 0);
                button.Left.Set(5, 0);
                button.Height.Set(38, 0);
                button.Width.Set(300, 0);

                this.Append(button);

                currentOption++;
            }

            BackButton = new MenuButton("Back");
            BackButton.Top.Set(this.Height.Pixels - 60, 0);
            BackButton.Left.Set(10, 0);
            BackButton.Height.Set(38, 0);
            BackButton.Width.Set(300, 0);
            BackButton.OnClick += GoToMainMenu;

            this.Append(BackButton);
        }

        public void AddOption(string optionName, Action<UIMouseEvent, UIElement> action = null)
        {
            MenuButton option = new MenuButton(optionName);

            if (action != null)
                option.OnClick += new UIElement.MouseEvent(action);

            MenuOptions.Add(option);
        }

        public void AddOption(string optionName, GunDefinition gun)
        {
            BuyOption option = new BuyOption(optionName, gun);

            MenuOptions.Add(option);
        }

        public void GoToMainMenu(UIMouseEvent evt, UIElement listeningElement)
        {
            BuyMenuState state = CSMod.Instance.BuyLayer.BuyUIState;
            state.RemoveChild(this);
            state.Append(state.MainMenu);
        }

        public List<MenuButton> MenuOptions { get; private set; }

        public MenuButton BackButton { get; private set; }
    }
}
