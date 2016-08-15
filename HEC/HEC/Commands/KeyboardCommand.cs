using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace HEC.Commands
{
    public enum KeyStates { UP, DOWN, PRESS, CTRL, ALT, SHIFT, WIN, CTRL_SHIFT }
    class KeyboardCommand : Command
    {
        private VirtualKeyCode key;
        private KeyStates state;

        public KeyboardCommand(VirtualKeyCode key, KeyStates state)
        {
            this.key = key;
            this.state = state;
            this.simulator = new InputSimulator();
        }

        public override void Run()
        {
            switch (state)
            {
                case KeyStates.UP:
                    Up(key);
                    break;
                case KeyStates.DOWN:
                    Down(key);
                    break;
                case KeyStates.PRESS:
                    Press(key);
                    break;
                case KeyStates.CTRL:
                    Ctrl();
                    break;
                case KeyStates.ALT:
                    Alt();
                    break;
                case KeyStates.SHIFT:
                    Shift();
                    break;
                case KeyStates.WIN:
                    Win();
                    break;
                case KeyStates.CTRL_SHIFT:
                    CtrlShift();
                    break;
                default:
                    Press(key);
                    break;
            }
        }

        protected override void Up(VirtualKeyCode key)
        {
            simulator.Keyboard.KeyUp(key);
        }
        protected override void Down(VirtualKeyCode key)
        {
            simulator.Keyboard.KeyDown(key);
        }
        protected override void Press(VirtualKeyCode key)
        {
            simulator.Keyboard.KeyPress(key);
        }

        protected void Ctrl()
        {
            VirtualKeyCode ctrlKey = VirtualKeyCode.CONTROL;
            Down(ctrlKey);
            Press(key);
            Up(ctrlKey);
        }
        protected void Alt()
        {
            VirtualKeyCode altKey = VirtualKeyCode.MENU;
            Down(altKey);
            Press(key);
            Up(altKey);
        }
        protected void Win()
        {
            VirtualKeyCode winKey = VirtualKeyCode.LWIN;
            Down(winKey);
            Press(key);
            Up(winKey);
        }
        protected void Shift()
        {
            VirtualKeyCode shiftKey = VirtualKeyCode.SHIFT;
            Down(shiftKey);
            Press(key);
            Up(shiftKey);
        }
        protected void CtrlShift()
        {
            VirtualKeyCode shiftKey = VirtualKeyCode.SHIFT;
            VirtualKeyCode ctrlKey = VirtualKeyCode.CONTROL;
            Down(ctrlKey);
            Down(shiftKey);
            Press(key);
            Up(shiftKey);
            Down(ctrlKey);
        }
    }
}
