using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.XInput;
using System.Threading;
using System.ComponentModel;
using HEC.ControllerMappings;
using System.Runtime.InteropServices;
using System.Diagnostics;
using WindowsInput;
using WindowsInput.Native;

namespace HEC
{

    public enum Buttons { A, B, X, Y,
        LT_A, LT_B, LT_X, LT_Y,
        RT_A, RT_B, RT_X, RT_Y,
        DPAD_UP, DPAD_RIGHT, DPAD_DOWN, DPAD_LEFT,
        LT_DPAD_UP, LT_DPAD_RIGHT, LT_DPAD_DOWN, LT_DPAD_LEFT,
        RT_DPAD_UP, RT_DPAD_RIGHT, RT_DPAD_DOWN, RT_DPAD_LEFT,
        R_BUMPER, L_BUMPER,
        LT_R_BUMPER, LT_L_BUMPER,
        RT_R_BUMPER, RT_L_BUMPER,
        START, MENU, RT, LT, L_STICK, R_STICK }

    enum Windows { DESKTOP,CHROME,VLC,GENERIC,SPOTIFY }

    class ControllerManager
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private BackgroundWorker controllerListener;
        private BackgroundWorker thumbstickListener;
        private BackgroundWorker windowListener;
        private ControllerMapping controllerMap;
        private WindowReader windowReader = new WindowReader();
        private ControllerInputReader inputReader;
        private ControllerInputReader mouseReader;
        private InputSimulator simulator;

        public HomeBase home;

        public ControllerManager()
        {
            inputReader = new HEC.ControllerInputReader();
            mouseReader = new HEC.ControllerInputReader();

            controllerListener = new BackgroundWorker();
            controllerListener.ProgressChanged += new ProgressChangedEventHandler(RunMacroForControl);
            controllerListener.WorkerReportsProgress = true;

            thumbstickListener = new BackgroundWorker();
            thumbstickListener.ProgressChanged += new ProgressChangedEventHandler(UpdateMouse);
            thumbstickListener.WorkerReportsProgress = true;

            windowReader = new WindowReader();

            windowListener = new BackgroundWorker();
            windowListener.ProgressChanged += new ProgressChangedEventHandler(updateControllerMappingForWindow);
            windowListener.WorkerReportsProgress = true;

            controllerMap = new GenericControllerMapping();

            simulator = new InputSimulator();

            home = new HEC.HomeBase();
            home.Show();
        }

        private void UpdateMouse(object sender, ProgressChangedEventArgs e)
        {
            int[] coordinates = (int[])e.UserState;
            int deltaX = 0;
            int deltaY = 0;
            int magnitudeX = 0;
            int magnitudeY = 0;
            float leftRatioX = (float) coordinates[0] / 32000;
            float leftRatioY = (float) coordinates[1] / 32000;
            float rightRatioX = (float)coordinates[2] / 32000;
            float rightRatioY = (float)coordinates[3] / 32000;

            if (Math.Abs(coordinates[0]) > 5000)
            {
                deltaX = (int) (15 * leftRatioX);
            }
            if (Math.Abs(coordinates[1]) > 5000)
            {
                deltaY = (int)(-1 * 15 * leftRatioY);
            }
            if (Math.Abs(coordinates[2]) > 5000)
            {
                magnitudeX = (int)(5 * rightRatioX);
            }
            if (Math.Abs(coordinates[3]) > 5000)
            {
                magnitudeY = (int)(5 * rightRatioY);
            }

            simulator.Mouse.VerticalScroll(magnitudeY);
            simulator.Mouse.HorizontalScroll(magnitudeX);
            simulator.Mouse.MoveMouseBy(deltaX, deltaY);
        }

        private void RunMacroForControl(object sender, ProgressChangedEventArgs e)
        {
            Buttons buttonID = (Buttons)e.ProgressPercentage;
            switch (buttonID)
            {
                case Buttons.A:
                    controllerMap.PerformActionA();
                    break;
                case Buttons.B:
                    controllerMap.PerformActionB();
                    break;
                case Buttons.X:
                    controllerMap.PerformActionX();
                    break;
                case Buttons.Y:
                    controllerMap.PerformActionY();
                    break;
                case Buttons.DPAD_UP:
                    controllerMap.PerformActionDPadUp();
                    break;
                case Buttons.DPAD_RIGHT:
                    controllerMap.PerformActionDPadRight();
                    break;
                case Buttons.DPAD_DOWN:
                    controllerMap.PerformActionDPadDown();
                    break;
                case Buttons.DPAD_LEFT:
                    controllerMap.PerformActionDPadLeft();
                    break;
                case Buttons.R_BUMPER:
                    controllerMap.PerformActionRBumper();
                    break;
                case Buttons.L_BUMPER:
                    controllerMap.PerformActionLBumper();
                    break;

                case Buttons.LT_A:
                    controllerMap.PerformActionLTA();
                    break;
                case Buttons.LT_B:
                    controllerMap.PerformActionLTB();
                    break;
                case Buttons.LT_X:
                    controllerMap.PerformActionLTX();
                    break;
                case Buttons.LT_Y:
                    controllerMap.PerformActionLTY();
                    break;
                case Buttons.LT_DPAD_UP:
                    controllerMap.PerformActionLTDPadUp();
                    break;
                case Buttons.LT_DPAD_RIGHT:
                    controllerMap.PerformActionLTDPadRight();
                    break;
                case Buttons.LT_DPAD_DOWN:
                    controllerMap.PerformActionLTDPadDown();
                    break;
                case Buttons.LT_DPAD_LEFT:
                    controllerMap.PerformActionLTDPadLeft();
                    break;
                case Buttons.LT_R_BUMPER:
                    controllerMap.PerformActionLTRBumper();
                    break;
                case Buttons.LT_L_BUMPER:
                    controllerMap.PerformActionLTLBumper();
                    break;

                case Buttons.RT_A:
                    controllerMap.PerformActionRTA();
                    break;
                case Buttons.RT_B:
                    controllerMap.PerformActionRTB();
                    break;
                case Buttons.RT_X:
                    controllerMap.PerformActionRTX();
                    break;
                case Buttons.RT_Y:
                    controllerMap.PerformActionRTY();
                    break;
                case Buttons.RT_DPAD_UP:
                    controllerMap.PerformActionRTDPadUp();
                    break;
                case Buttons.RT_DPAD_RIGHT:
                    controllerMap.PerformActionRTDPadRight();
                    break;
                case Buttons.RT_DPAD_DOWN:
                    controllerMap.PerformActionRTDPadDown();
                    break;
                case Buttons.RT_DPAD_LEFT:
                    controllerMap.PerformActionRTDPadLeft();
                    break;
                case Buttons.RT_R_BUMPER:
                    controllerMap.PerformActionRTRBumper();
                    break;
                case Buttons.RT_L_BUMPER:
                    controllerMap.PerformActionRTLBumper();
                    break;

                case Buttons.START:
                    controllerMap.PerformActionStart();
                    break;
                case Buttons.MENU:
                    controllerMap.PerformActionMenu();
                    break;
                case Buttons.L_STICK:
                    controllerMap.PerformActionLStick();
                    break;
                default:
                    break;
            }
        }

        private void updateControllerMappingForWindow(object sender, ProgressChangedEventArgs e)
        {
            Windows windowID = (Windows)e.ProgressPercentage;
            switch (windowID)
            {
                case Windows.DESKTOP:
                    controllerMap = new DesktopControllerMapping();
                    break;
                case Windows.CHROME:
                    controllerMap = new ChromeControllerMapping();
                    break;
                case Windows.VLC:
                    controllerMap = new VLCControllerMapping();
                    break;
                case Windows.SPOTIFY:
                    controllerMap = new SpotifyControllerMapping();
                    break;
                case Windows.GENERIC:
                    controllerMap = new GenericControllerMapping();
                    break;
                default:
                    break;
            }
            home.SetToolBarItemsWithMapping(controllerMap.macros);
        }

        private bool DidPressButton(GamepadButtonFlags buttonFlag, GamepadButtonFlags oldFlags, GamepadButtonFlags newFlags)
        {
            if (!oldFlags.HasFlag(buttonFlag) && newFlags.HasFlag(buttonFlag))
                return true;
            return false;
        }

        private bool DidPressRTrigger(Gamepad pad)
        {
            if (pad.RightTrigger > 200)
            {
                return true;
            }
            return false;
        }
        private bool DidPressLTrigger(Gamepad pad)
        {
            if (pad.LeftTrigger > 200)
            {
                return true;
            }
            return false;
        }

        public void listenForControllerInput()
        {
            thumbstickListener.DoWork += new DoWorkEventHandler(
                delegate (Object o, DoWorkEventArgs args)
                {
                    ControllerInputReader reader = (ControllerInputReader)args.Argument;
                    if (reader == null) return;
                    BackgroundWorker b = o as BackgroundWorker;

                    while (reader.CanRead())
                    {
                        int[] coordinates = reader.GetThumbCoordinates();
                        thumbstickListener.ReportProgress(1, coordinates);
                        Thread.Sleep(10);
                    }
                }
            );

            controllerListener.DoWork += new DoWorkEventHandler(
                delegate (Object o, DoWorkEventArgs args)
                {
                    ControllerInputReader reader = (ControllerInputReader)args.Argument;
                    if (reader == null) return;

                    BackgroundWorker b = o as BackgroundWorker;

                    State oldState = inputReader.GetState();
                    GamepadButtonFlags oldButtonFlags = oldState.Gamepad.Buttons;

                    while (reader.CanRead())
                    {
                        var state = inputReader.GetState();
                        if (oldState.PacketNumber != state.PacketNumber)
                        {
                            GamepadButtonFlags buttonFlags = state.Gamepad.Buttons;
                            if (DidPressRTrigger(state.Gamepad))
                            {
                                if (DidPressButton(GamepadButtonFlags.A, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_A);
                                }
                                if (DidPressButton(GamepadButtonFlags.B, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_B);
                                }
                                if (DidPressButton(GamepadButtonFlags.X, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_X);
                                }
                                if (DidPressButton(GamepadButtonFlags.Y, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_Y);
                                }
                                if (DidPressButton(GamepadButtonFlags.LeftShoulder,oldButtonFlags,buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_L_BUMPER);
                                }
                                if (DidPressButton(GamepadButtonFlags.RightShoulder, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_R_BUMPER);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadUp, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_DPAD_UP);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadRight, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_DPAD_RIGHT);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadDown, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_DPAD_DOWN, true);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadLeft, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.RT_DPAD_LEFT, true);
                                }
                            }
                            else if (DidPressLTrigger(state.Gamepad))
                            {
                                if (DidPressButton(GamepadButtonFlags.A, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_A);
                                }
                                if (DidPressButton(GamepadButtonFlags.B, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_B);
                                }
                                if (DidPressButton(GamepadButtonFlags.X, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_X);
                                }
                                if (DidPressButton(GamepadButtonFlags.Y, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_Y);
                                }
                                if (DidPressButton(GamepadButtonFlags.LeftShoulder, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_L_BUMPER);
                                }
                                if (DidPressButton(GamepadButtonFlags.RightShoulder, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_R_BUMPER);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadUp, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_DPAD_UP);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadRight, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_DPAD_RIGHT);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadDown, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_DPAD_DOWN, true);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadLeft, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.LT_DPAD_LEFT, true);
                                }
                            }
                            else
                            {
                                if (DidPressButton(GamepadButtonFlags.A, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.A);
                                }
                                if (DidPressButton(GamepadButtonFlags.B, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.B);
                                }
                                if (DidPressButton(GamepadButtonFlags.X, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.X);
                                }
                                if (DidPressButton(GamepadButtonFlags.Y, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.Y);
                                }
                                if (DidPressButton(GamepadButtonFlags.LeftShoulder, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.L_BUMPER);
                                }
                                if (DidPressButton(GamepadButtonFlags.RightShoulder, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.R_BUMPER);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadUp, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.DPAD_UP);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadRight, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.DPAD_RIGHT);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadDown, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.DPAD_DOWN, true);
                                }
                                if (DidPressButton(GamepadButtonFlags.DPadLeft, oldButtonFlags, buttonFlags))
                                {
                                    controllerListener.ReportProgress((int)Buttons.DPAD_LEFT, true);
                                }
                            }
                            if (DidPressButton(GamepadButtonFlags.Start, oldButtonFlags, buttonFlags))
                            {
                                controllerListener.ReportProgress((int)Buttons.START, true);
                            }
                            if (DidPressButton(GamepadButtonFlags.Back, oldButtonFlags, buttonFlags))
                            {
                                controllerListener.ReportProgress((int)Buttons.MENU, true);
                            }
                            if (DidPressButton(GamepadButtonFlags.LeftThumb, oldButtonFlags, buttonFlags))
                            {
                                controllerListener.ReportProgress((int)Buttons.L_STICK, true);
                            }
                        }
                        Thread.Sleep(10);
                        oldState = state;
                        oldButtonFlags = oldState.Gamepad.Buttons;
                    }
                });

            controllerListener.RunWorkerAsync(inputReader);
            thumbstickListener.RunWorkerAsync(mouseReader);
        }

        public void listenForActiveWindow()
        {
            windowListener.DoWork += new DoWorkEventHandler(
                delegate (Object o, DoWorkEventArgs args)
                {
                    WindowReader reader = (WindowReader)args.Argument;
                    if (reader == null) return;

                    BackgroundWorker b = o as BackgroundWorker;
                    Windows oldWindow = reader.GetActiveWindow();

                    while (true)
                    {
                        Windows newWindow = reader.GetActiveWindow();
                        if (newWindow != oldWindow)
                        {
                            windowListener.ReportProgress((int)newWindow);
                        }
                        Thread.Sleep(10);
                        oldWindow = newWindow;
                    }
                });

            windowListener.RunWorkerAsync(windowReader);
        }
    }
}
