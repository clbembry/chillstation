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

namespace HEC
{

    enum Buttons { A, B, X, Y, DPadUp, DPadRight, DPadDown, DPadLeft, Start = 15 };

    class ControllerManager
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        private Controller controller;
        private BackgroundWorker controllerListener;
        private BackgroundWorker windowListener;
        private ControllerMapping controllerMap;

        public ControllerManager()
        {
            this.initController();
            controllerListener = new BackgroundWorker();
            controllerListener.ProgressChanged += new ProgressChangedEventHandler(runMacroForControl);
            controllerListener.WorkerReportsProgress = true;

            windowListener = new BackgroundWorker();
            windowListener.ProgressChanged += new ProgressChangedEventHandler(updateControllerMapping);
            windowListener.WorkerReportsProgress = true;

            controllerMap = new DesktopControllerMapping();
        }

        public void listenForActiveWindow()
        {
            windowListener.DoWork += new DoWorkEventHandler(
                delegate (Object o, DoWorkEventArgs args)
                {
                    BackgroundWorker b = o as BackgroundWorker;
                    String previousState = GetActiveWindowTitle();

                    while (true)
                    {
                        String state = GetActiveWindowTitle();
                        if (state != previousState)
                        {
                            b.ReportProgress(state, true);
                        }
                        Thread.Sleep(10);
                        previousState = state;
                    }
                });

            windowListener.RunWorkerAsync();
        }

        private void updateControllerMappingForWindow(object sender, ProgressChangedEventArgs e)
        {

        }

        public void listenForControllerInput()
        {
            controllerListener.DoWork += new DoWorkEventHandler(
                    delegate (Object o, DoWorkEventArgs args)
                    {
                        BackgroundWorker b = o as BackgroundWorker;
                        Controller c = (Controller)args.Argument;
                        if (c == null) return;
                        var previousState = controller.GetState();

                        while (c.IsConnected)
                        {
                            var state = controller.GetState();
                            if (previousState.PacketNumber != state.PacketNumber)
                            {
                                GamepadButtonFlags buttonFlags = state.Gamepad.Buttons;
                                if (buttonFlags.HasFlag(GamepadButtonFlags.A))
                                {
                                    controllerListener.ReportProgress(0, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.B))
                                {
                                    controllerListener.ReportProgress(1, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.X))
                                {
                                    controllerListener.ReportProgress(2, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.Y))
                                {
                                    controllerListener.ReportProgress(3, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.DPadUp))
                                {
                                    controllerListener.ReportProgress(4, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.DPadRight))
                                {
                                    controllerListener.ReportProgress(5, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.DPadDown))
                                {
                                    controllerListener.ReportProgress(6, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.DPadLeft))
                                {
                                    controllerListener.ReportProgress(7, true);
                                }
                                if (buttonFlags.HasFlag(GamepadButtonFlags.Start))
                                {
                                    controllerListener.ReportProgress(15, true);
                                }
                            }
                            Thread.Sleep(10);
                            previousState = state;
                        }

                    });

            controllerListener.RunWorkerAsync(controller);
        }

        private void runMacroForControl(object sender, ProgressChangedEventArgs e)
        {
            Buttons buttonID = (Buttons)e.ProgressPercentage;

            bool state = (bool)e.UserState;
            switch (buttonID)
            {
                case Buttons.A:
                    controllerMap.performActionA();
                    break;
                case Buttons.B:
                    break;
                case Buttons.X:
                    break;
                case Buttons.Y:
                    break;
                case Buttons.DPadUp:
                    controllerMap.performActionDPadUp();
                    break;
                case Buttons.DPadRight:
                    controllerMap.performActionDPadRight();
                    break;
                case Buttons.DPadDown:
                    controllerMap.performActionDPadDown();
                    break;
                case Buttons.DPadLeft:
                    controllerMap.performActionDPadLeft();
                    break;
                case Buttons.Start:
                    controllerMap.performActionStart();
                    break;
                default:
                    break;

            }
        }

        private void initController()
        {
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
            foreach (var selectControler in controllers)
            {
                if (selectControler.IsConnected)
                {
                    this.controller = selectControler;
                    break;
                }
            }
        }

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
    }
}
