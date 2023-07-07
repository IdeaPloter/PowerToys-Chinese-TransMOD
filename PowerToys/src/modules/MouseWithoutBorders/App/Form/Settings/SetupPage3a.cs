// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Drawing;
using System.Windows.Forms;
using MouseWithoutBorders.Class;
using MouseWithoutBorders.Properties;

namespace MouseWithoutBorders
{
    public partial class SetupPage3a : SettingsFormPage
    {
        private readonly Image[] _frames = { Images.copy_paste_example, Images.drag_example, Images.keyboard_example };
        private readonly string[] _messages =
        {
                                                  "����Ը���ճ��",
                                                  "�������ק�ļ�",
                                                  "����һ��������",
        };

        private readonly int[] _timing = { 1000, 1000, 2000 };
#pragma warning disable CA2213 // Disposing is done by ComponentResourceManager
        private readonly System.Timers.Timer _animationTimer;
#pragma warning restore CA2213
        private bool connected;
        private bool done;
        private bool invalidKey;

        private int _animationFrame;

        public bool ReturnToSettings { get; set; }

        public SetupPage3a()
        {
            InitializeComponent();
            _animationTimer = new System.Timers.Timer { Interval = 1000 };
        }

        private void ShowStatus(string status)
        {
            labelStatus.Text = status;
            Common.Log(status);
        }

        public override void OnPageClosing()
        {
            _animationTimer.Stop();
            base.OnPageClosing();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _animationTimer.Elapsed += AnimationTimerTick;

            Common.GetMachineName();
            invalidKey = false;

            UpdateAnimation();
            _animationTimer.Start();

            SocketStuff.InvalidKeyFound = false;
            SocketStuff.InvalidKeyFoundOnClientSocket = false;

            ShowStatus($"����������...");

            Common.SwitchToMultipleMode(false, false);
            Common.ReopenSockets(true);

            int timeOut = 0;
            TcpSk connectedClientSocket;

            // Client sockets run in different threads.
            while (timeOut < 10)
            {
                Common.MMSleep(1);

                if ((connectedClientSocket = Common.GetConnectedClientSocket()) != null)
                {
                    ShowStatus($"�����ӱ��� IP ��ַ: {connectedClientSocket.Address}.");
                    Common.UpdateMachineTimeAndID();

                    Common.MMSleep(1);
                    connected = true;
                    return;
                }
                else if (SocketStuff.InvalidKeyFoundOnClientSocket)
                {
                    invalidKey = true;
                    ShowStatus("״̬: ������Ч.");
                    Common.MMSleep(3);
                    break;
                }

                timeOut++;
            }

            done = true;
        }

        private void AnimationTimerTick(object sender, EventArgs e)
        {
            _ = Invoke(new MethodInvoker(UpdateAnimation));
        }

        private void UpdateAnimation()
        {
            if ((ModifierKeys & Keys.Control) != 0)
            {
                _animationTimer.Stop();
                SendNextPage(new SetupPage2ab());
                return;
            }

            ExamplePicture.Image = _frames[_animationFrame];
            MessageLabel.Text = _messages[_animationFrame];
            _animationTimer.Interval = _timing[_animationFrame];
            _animationFrame = (_animationFrame + 1) % _frames.Length;

            if (connected)
            {
                _animationTimer.Stop();
                SendNextPage(new SetupPage4());
            }
            else if (done)
            {
                _animationTimer.Stop();
                SendNextPage(new SetupPage2ab());

                if (invalidKey)
                {
                    Common.ShowToolTip(
                        "���벻��ȷ��\r\n�����Ƿ������е����϶�������ͬһ�����롣\r\n����������е��Ƿ���ͬһ�汾�� "
                        + Application.ProductName + "��\r\n������汾: " + FrmAbout.AssemblyVersion,
                        20000);
                }
                else
                {
                    string helpText = "���ӳ���!";
                    helpText += "\r\n�������ĵ����Ƿ����ӵ�ͬһ�����磬һ���Ƽ������߸��ȶ���";
                    helpText += "\r\n������� " + Application.ProductName + " �ǲ��Ǳ�ϵͳ����ǽ�����ˡ�";
                    Common.ShowToolTip(helpText, 30000);
                }
            }
        }
    }
}
