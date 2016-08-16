using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEC.Models
{
    public enum Icons { BUTTON_A, BUTTON_B, BUTTON_X, BUTTON_Y, BUTTON_LB, BUTTON_RB, DPAD_UP, DPAD_RIGHT, DPAD_DOWN, DPAD_LEFT, START, MENU, RT, LT }
    public class Icon
    {
        public String Title;
        public String ResourcePath;

        public Icon(String title, String resourcePath)
        {
            this.Title = title;
            this.ResourcePath = resourcePath;
        }

        public static string IconForButton(Buttons button)
        {
            switch (button)
            {
                case Buttons.A:
                    return "/Resources/AButton.png";
                case Buttons.B:
                    return "/Resources/BButton.png";
                case Buttons.X:
                    return "/Resources/XButton.png";
                case Buttons.Y:
                    return "/Resources/YButton.png";
                case Buttons.L_BUMPER:
                    return "/Resources/LBumper.png";
                case Buttons.R_BUMPER:
                    return "/Resources/RBumper.png";
                case Buttons.DPAD_UP:
                    return "/Resources/DPadUp.png";
                case Buttons.DPAD_RIGHT:
                    return "/Resources/DPadRight.png";
                case Buttons.DPAD_DOWN:
                    return "/Resources/DPadDown.png";
                case Buttons.DPAD_LEFT:
                    return "/Resources/DPadLeft.png";
                case Buttons.START:
                    return "/Resources/MenuButton.png";
                case Buttons.MENU:
                    return "/Resources/StartButton.png";
                default:
                    return "";
            }

        }

    }
}