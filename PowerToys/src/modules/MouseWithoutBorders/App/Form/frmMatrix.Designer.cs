﻿using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace MouseWithoutBorders
{
    partial class FrmMatrix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMatrix));
            this.pictureBoxMouseWithoutBorders0 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBoxLockMachine = new System.Windows.Forms.ComboBox();
            this.comboBoxSwitchToAllPC = new System.Windows.Forms.ComboBox();
            this.comboBoxReconnect = new System.Windows.Forms.ComboBox();
            this.checkBoxTwoRow = new System.Windows.Forms.CheckBox();
            this.comboBoxEasyMouse = new System.Windows.Forms.ComboBox();
            this.checkBoxDrawMouse = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseMoveRelatively = new System.Windows.Forms.CheckBox();
            this.checkBoxHideMouse = new System.Windows.Forms.CheckBox();
            this.checkBoxBlockMouseAtCorners = new System.Windows.Forms.CheckBox();
            this.checkBoxCircle = new System.Windows.Forms.CheckBox();
            this.checkBoxBlockScreenSaver = new System.Windows.Forms.CheckBox();
            this.checkBoxHideLogo = new System.Windows.Forms.CheckBox();
            this.checkBoxShareClipboard = new System.Windows.Forms.CheckBox();
            this.checkBoxDisableCAD = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxReverseLookup = new System.Windows.Forms.CheckBox();
            this.checkBoxVKMap = new System.Windows.Forms.CheckBox();
            this.comboBoxScreenCapture = new System.Windows.Forms.ComboBox();
            this.checkBoxSameSubNet = new System.Windows.Forms.CheckBox();
            this.checkBoxClipNetStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxSendLog = new System.Windows.Forms.CheckBox();
            this.groupBoxKeySetup = new System.Windows.Forms.GroupBox();
            this.buttonNewKey = new System.Windows.Forms.Button();
            this.textBoxEnc = new System.Windows.Forms.TextBox();
            this.LabelEnc = new System.Windows.Forms.Label();
            this.checkBoxShowKey = new System.Windows.Forms.CheckBox();
            this.labelEasyMouse = new System.Windows.Forms.Label();
            this.comboBoxEasyMouseOption = new System.Windows.Forms.ComboBox();
            this.checkBoxTransferFile = new System.Windows.Forms.CheckBox();
            this.toolTipManual = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.groupBoxOtherOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxShortcuts = new System.Windows.Forms.GroupBox();
            this.labelScreenCapture = new System.Windows.Forms.Label();
            this.LabelToggleEasyMouse = new System.Windows.Forms.Label();
            this.comboBoxExitMM = new System.Windows.Forms.ComboBox();
            this.comboBoxShowSettings = new System.Windows.Forms.ComboBox();
            this.labelReconnect = new System.Windows.Forms.Label();
            this.labelSwitch2AllPCMode = new System.Windows.Forms.Label();
            this.radioButtonDisable = new System.Windows.Forms.RadioButton();
            this.radioButtonNum = new System.Windows.Forms.RadioButton();
            this.radioButtonF1 = new System.Windows.Forms.RadioButton();
            this.labelLockMachine = new System.Windows.Forms.Label();
            this.labelExitMM = new System.Windows.Forms.Label();
            this.labelShowSettings = new System.Windows.Forms.Label();
            this.labelSwitchBetweenMachine = new System.Windows.Forms.Label();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxMachineMatrix = new System.Windows.Forms.GroupBox();
            this.linkLabelReConfigure = new System.Windows.Forms.LinkLabel();
            this.tabControlSetting = new System.Windows.Forms.TabControl();
            this.tabPageAdvancedSettings = new System.Windows.Forms.TabPage();
            this.pictureBoxMouseWithoutBorders = new System.Windows.Forms.PictureBox();
            this.groupBoxDNS = new System.Windows.Forms.GroupBox();
            this.textBoxMachineName2IP = new System.Windows.Forms.TextBox();
            this.textBoxDNS = new System.Windows.Forms.TextBox();
            this.linkLabelHelp = new System.Windows.Forms.LinkLabel();
            this.linkLabelMiniLog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseWithoutBorders0)).BeginInit();
            this.groupBoxKeySetup.SuspendLayout();
            this.tabPageOther.SuspendLayout();
            this.groupBoxOtherOptions.SuspendLayout();
            this.groupBoxShortcuts.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxMachineMatrix.SuspendLayout();
            this.tabControlSetting.SuspendLayout();
            this.tabPageAdvancedSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseWithoutBorders)).BeginInit();
            this.groupBoxDNS.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMouseWithoutBorders0
            // 
            this.pictureBoxMouseWithoutBorders0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMouseWithoutBorders0.BackgroundImage")));
            this.pictureBoxMouseWithoutBorders0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxMouseWithoutBorders0.Location = new System.Drawing.Point(590, 271);
            this.pictureBoxMouseWithoutBorders0.Name = "pictureBoxMouseWithoutBorders0";
            this.pictureBoxMouseWithoutBorders0.Size = new System.Drawing.Size(190, 54);
            this.pictureBoxMouseWithoutBorders0.TabIndex = 16;
            this.pictureBoxMouseWithoutBorders0.TabStop = false;
            this.pictureBoxMouseWithoutBorders0.Visible = false;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 100;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.ReshowDelay = 20;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Microsoft® Visual Studio® 2010";
            // 
            // comboBoxLockMachine
            // 
            this.comboBoxLockMachine.Enabled = true;
            this.comboBoxLockMachine.FormattingEnabled = true;
            this.comboBoxLockMachine.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "关闭"});
            this.comboBoxLockMachine.Location = new System.Drawing.Point(230, 68);
            this.comboBoxLockMachine.Name = "comboBoxLockMachine";
            this.comboBoxLockMachine.Size = new System.Drawing.Size(54, 21);
            this.comboBoxLockMachine.TabIndex = 205;
            this.comboBoxLockMachine.Text = "L";
            this.toolTip.SetToolTip(this.comboBoxLockMachine, "双击锁定所有电脑。");
            this.comboBoxLockMachine.TextChanged += new System.EventHandler(this.ComboBoxLockMachine_TextChanged);
            // 
            // comboBoxSwitchToAllPC
            // 
            this.comboBoxSwitchToAllPC.Enabled = true;
            this.comboBoxSwitchToAllPC.FormattingEnabled = true;
            this.comboBoxSwitchToAllPC.Items.AddRange(new object[] {
            "Ctrl*3",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "关闭"});
            this.comboBoxSwitchToAllPC.Location = new System.Drawing.Point(490, 68);
            this.comboBoxSwitchToAllPC.Name = "comboBoxSwitchToAllPC";
            this.comboBoxSwitchToAllPC.Size = new System.Drawing.Size(56, 21);
            this.comboBoxSwitchToAllPC.TabIndex = 206;
            this.comboBoxSwitchToAllPC.Text = "关闭";
            this.toolTip.SetToolTip(this.comboBoxSwitchToAllPC, "按三次 Ctrl 或者 Ctrl+Alt+[?]");
            this.comboBoxSwitchToAllPC.TextChanged += new System.EventHandler(this.ComboBoxSwitchToAllPC_TextChanged);
            // 
            // comboBoxReconnect
            // 
            this.comboBoxReconnect.Enabled = true;
            this.comboBoxReconnect.FormattingEnabled = true;
            this.comboBoxReconnect.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "关闭"});
            this.comboBoxReconnect.Location = new System.Drawing.Point(230, 95);
            this.comboBoxReconnect.Name = "comboBoxReconnect";
            this.comboBoxReconnect.Size = new System.Drawing.Size(54, 21);
            this.comboBoxReconnect.TabIndex = 207;
            this.comboBoxReconnect.Text = "R";
            this.toolTip.SetToolTip(this.comboBoxReconnect, "防止连接丢失。");
            this.comboBoxReconnect.TextChanged += new System.EventHandler(this.ComboBoxReconnect_TextChanged);
            // 
            // checkBoxTwoRow
            // 
            this.checkBoxTwoRow.AutoSize = true;
            this.checkBoxTwoRow.Location = new System.Drawing.Point(9, 205);
            this.checkBoxTwoRow.Name = "checkBoxTwoRow";
            this.checkBoxTwoRow.Size = new System.Drawing.Size(72, 17);
            this.checkBoxTwoRow.TabIndex = 6;
            this.checkBoxTwoRow.Text = "双行排列(&R)";
            this.toolTip.SetToolTip(this.checkBoxTwoRow, "选中改为上下两行，可上下移动鼠标来切换设备。");
            this.checkBoxTwoRow.UseVisualStyleBackColor = true;
            this.checkBoxTwoRow.CheckedChanged += new System.EventHandler(this.CheckBoxTwoRow_CheckedChanged);
            // 
            // comboBoxEasyMouse
            // 
            this.comboBoxEasyMouse.Enabled = true;
            this.comboBoxEasyMouse.FormattingEnabled = true;
            this.comboBoxEasyMouse.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "关闭"});
            this.comboBoxEasyMouse.Location = new System.Drawing.Point(490, 122);
            this.comboBoxEasyMouse.Name = "comboBoxEasyMouse";
            this.comboBoxEasyMouse.Size = new System.Drawing.Size(56, 21);
            this.comboBoxEasyMouse.TabIndex = 208;
            this.comboBoxEasyMouse.Text = "E";
            this.toolTip.SetToolTip(this.comboBoxEasyMouse, "切换易动功能的开关，易动设置为按住按键开启时该切换无效。");
            this.comboBoxEasyMouse.TextChanged += new System.EventHandler(this.ComboBoxEasyMouse_TextChanged);
            // 
            // checkBoxDrawMouse
            // 
            this.checkBoxDrawMouse.AutoSize = true;
            this.checkBoxDrawMouse.Checked = true;
            this.checkBoxDrawMouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawMouse.Location = new System.Drawing.Point(9, 118);
            this.checkBoxDrawMouse.Name = "checkBoxDrawMouse";
            this.checkBoxDrawMouse.Size = new System.Drawing.Size(117, 17);
            this.checkBoxDrawMouse.TabIndex = 171;
            this.checkBoxDrawMouse.Text = "绘制鼠标光标(&D)";
            this.toolTip.SetToolTip(this.checkBoxDrawMouse, "在 Win10 以上，如果电脑没插鼠标，那么默认不会显示鼠标光标，需要单独绘制。");
            this.checkBoxDrawMouse.UseVisualStyleBackColor = true;
            this.checkBoxDrawMouse.CheckedChanged += new System.EventHandler(this.CheckBoxDrawMouse_CheckedChanged);
            // 
            // checkBoxMouseMoveRelatively
            // 
            this.checkBoxMouseMoveRelatively.AutoSize = true;
            this.checkBoxMouseMoveRelatively.Checked = true;
            this.checkBoxMouseMoveRelatively.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMouseMoveRelatively.Location = new System.Drawing.Point(268, 53);
            this.checkBoxMouseMoveRelatively.Name = "checkBoxMouseMoveRelatively";
            this.checkBoxMouseMoveRelatively.Size = new System.Drawing.Size(131, 17);
            this.checkBoxMouseMoveRelatively.TabIndex = 170;
            this.checkBoxMouseMoveRelatively.Text = "鼠标相对移动(&M)";
            this.toolTip.SetToolTip(this.checkBoxMouseMoveRelatively, "提供不同屏幕配置和多屏使用的支持。");
            this.checkBoxMouseMoveRelatively.UseVisualStyleBackColor = true;
            this.checkBoxMouseMoveRelatively.CheckedChanged += new System.EventHandler(this.CheckBoxMouseMoveRelatively_CheckedChanged);
            // 
            // checkBoxHideMouse
            // 
            this.checkBoxHideMouse.AutoSize = true;
            this.checkBoxHideMouse.Checked = true;
            this.checkBoxHideMouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHideMouse.Location = new System.Drawing.Point(9, 96);
            this.checkBoxHideMouse.Name = "checkBoxHideMouse";
            this.checkBoxHideMouse.Size = new System.Drawing.Size(156, 17);
            this.checkBoxHideMouse.TabIndex = 169;
            this.checkBoxHideMouse.Text = "移出屏幕隐藏鼠标(&H)";
            this.toolTip.SetToolTip(this.checkBoxHideMouse, "鼠标移出屏幕后，把本设备光标隐藏在屏幕顶部，消除当前窗口焦点，使键盘输入转移到被控电脑。");
            this.checkBoxHideMouse.UseVisualStyleBackColor = true;
            this.checkBoxHideMouse.CheckedChanged += new System.EventHandler(this.CheckBoxHideMouse_CheckedChanged);
            // 
            // checkBoxBlockMouseAtCorners
            // 
            this.checkBoxBlockMouseAtCorners.AutoSize = true;
            this.checkBoxBlockMouseAtCorners.Location = new System.Drawing.Point(268, 75);
            this.checkBoxBlockMouseAtCorners.Name = "checkBoxBlockMouseAtCorners";
            this.checkBoxBlockMouseAtCorners.Size = new System.Drawing.Size(172, 17);
            this.checkBoxBlockMouseAtCorners.TabIndex = 172;
            this.checkBoxBlockMouseAtCorners.Text = "屏幕四角阻挡";
            this.toolTip.SetToolTip(this.checkBoxBlockMouseAtCorners, "在屏幕四角处阻挡跨界，防止误触。");
            this.checkBoxBlockMouseAtCorners.UseVisualStyleBackColor = true;
            this.checkBoxBlockMouseAtCorners.CheckedChanged += new System.EventHandler(this.CheckBoxBlockMouseAtCorners_CheckedChanged);
            // 
            // checkBoxCircle
            // 
            this.checkBoxCircle.AutoSize = true;
            this.checkBoxCircle.Location = new System.Drawing.Point(9, 11);
            this.checkBoxCircle.Name = "checkBoxCircle";
            this.checkBoxCircle.Size = new System.Drawing.Size(87, 17);
            this.checkBoxCircle.TabIndex = 163;
            this.checkBoxCircle.Text = "循环移动(&W)";
            this.toolTip.SetToolTip(this.checkBoxCircle, "鼠标移动超过最后一台电脑屏幕后，回到第一台电脑上。");
            this.checkBoxCircle.UseVisualStyleBackColor = true;
            this.checkBoxCircle.CheckedChanged += new System.EventHandler(this.CheckBoxCircle_CheckedChanged);
            // 
            // checkBoxBlockScreenSaver
            // 
            this.checkBoxBlockScreenSaver.AutoSize = true;
            this.checkBoxBlockScreenSaver.Checked = true;
            this.checkBoxBlockScreenSaver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBlockScreenSaver.Location = new System.Drawing.Point(268, 32);
            this.checkBoxBlockScreenSaver.Name = "checkBoxBlockScreenSaver";
            this.checkBoxBlockScreenSaver.Size = new System.Drawing.Size(211, 17);
            this.checkBoxBlockScreenSaver.TabIndex = 168;
            this.checkBoxBlockScreenSaver.Text = "阻止屏保(&B)";
            this.toolTip.SetToolTip(this.checkBoxBlockScreenSaver, "阻止被控电脑启动屏幕保护程序。");
            this.checkBoxBlockScreenSaver.UseVisualStyleBackColor = true;
            this.checkBoxBlockScreenSaver.CheckedChanged += new System.EventHandler(this.CheckBoxBlockScreenSaver_CheckedChanged);
            // 
            // checkBoxHideLogo
            // 
            this.checkBoxHideLogo.AutoSize = true;
            this.checkBoxHideLogo.Location = new System.Drawing.Point(9, 75);
            this.checkBoxHideLogo.Name = "checkBoxHideLogo";
            this.checkBoxHideLogo.Size = new System.Drawing.Size(164, 17);
            this.checkBoxHideLogo.TabIndex = 167;
            this.checkBoxHideLogo.Text = "登录时不显示 &Logo";
            this.toolTip.SetToolTip(this.checkBoxHideLogo, "隐藏登录桌面上的“微软无界鼠标”字样。");
            this.checkBoxHideLogo.UseVisualStyleBackColor = true;
            this.checkBoxHideLogo.CheckedChanged += new System.EventHandler(this.CheckBoxHideLogo_CheckedChanged);
            // 
            // checkBoxShareClipboard
            // 
            this.checkBoxShareClipboard.AutoSize = true;
            this.checkBoxShareClipboard.Checked = true;
            this.checkBoxShareClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShareClipboard.Location = new System.Drawing.Point(9, 32);
            this.checkBoxShareClipboard.Name = "checkBoxShareClipboard";
            this.checkBoxShareClipboard.Size = new System.Drawing.Size(101, 17);
            this.checkBoxShareClipboard.TabIndex = 165;
            this.checkBoxShareClipboard.Text = "共享剪贴板(&S)";
            this.toolTip.SetToolTip(this.checkBoxShareClipboard, "共享复制的内容，如果功能突然失效，按 Ctrl + Alt + Del 然后按 Esc 也许可以解决问题。");
            this.checkBoxShareClipboard.UseVisualStyleBackColor = true;
            this.checkBoxShareClipboard.CheckedChanged += new System.EventHandler(this.CheckBoxShareClipboard_CheckedChanged);
            // 
            // checkBoxDisableCAD
            // 
            this.checkBoxDisableCAD.AutoSize = true;
            this.checkBoxDisableCAD.Checked = true;
            this.checkBoxDisableCAD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDisableCAD.Location = new System.Drawing.Point(268, 11);
            this.checkBoxDisableCAD.Name = "checkBoxDisableCAD";
            this.checkBoxDisableCAD.Size = new System.Drawing.Size(86, 17);
            this.checkBoxDisableCAD.TabIndex = 166;
            this.checkBoxDisableCAD.Text = "禁用 Ctrl+Alt+Del 登录(&C)";
            this.toolTip.SetToolTip(this.checkBoxDisableCAD, "不需要按 Ctrl+Alt+Del 登录");
            this.checkBoxDisableCAD.UseVisualStyleBackColor = true;
            this.checkBoxDisableCAD.CheckedChanged += new System.EventHandler(this.CheckBoxDisableCAD_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(187, 328);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 20;
            this.buttonOK.Text = "应用(&A)";
            this.toolTip.SetToolTip(this.buttonOK, "保存设置，刷新连接。");
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // checkBoxReverseLookup
            // 
            this.checkBoxReverseLookup.AutoSize = true;
            this.checkBoxReverseLookup.Location = new System.Drawing.Point(9, 141);
            this.checkBoxReverseLookup.Name = "checkBoxReverseLookup";
            this.checkBoxReverseLookup.Size = new System.Drawing.Size(196, 17);
            this.checkBoxReverseLookup.TabIndex = 173;
            this.checkBoxReverseLookup.Text = "验证远程设备地址(&V)";
            this.toolTip.SetToolTip(this.checkBoxReverseLookup, "通过反向 DNS 查找来验证远程电脑的 IP 地址（高级功能，如有疑问查看在线帮助）");
            this.checkBoxReverseLookup.UseVisualStyleBackColor = true;
            this.checkBoxReverseLookup.CheckedChanged += new System.EventHandler(this.CheckBoxReverseLookup_CheckedChanged);
            // 
            // checkBoxVKMap
            // 
            this.checkBoxVKMap.Enabled = false;
            this.checkBoxVKMap.AutoSize = true;
            this.checkBoxVKMap.Location = new System.Drawing.Point(268, 98);
            this.checkBoxVKMap.Name = "checkBoxVKMap";
            this.checkBoxVKMap.Size = new System.Drawing.Size(115, 17);
            this.checkBoxVKMap.TabIndex = 174;
            this.checkBoxVKMap.Text = "启用按键映射(&U)";
            this.toolTip.SetToolTip(this.checkBoxVKMap, "使用按键映射来改变快捷键，详情参阅在线帮助。");
            this.checkBoxVKMap.UseVisualStyleBackColor = true;
            this.checkBoxVKMap.CheckedChanged += new System.EventHandler(this.CheckBoxVKMap_CheckedChanged);
            // 
            // comboBoxScreenCapture
            // 
            this.comboBoxScreenCapture.Enabled = false;
            this.comboBoxScreenCapture.FormattingEnabled = true;
            this.comboBoxScreenCapture.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "关闭"});
            this.comboBoxScreenCapture.Location = new System.Drawing.Point(230, 121);
            this.comboBoxScreenCapture.Name = "comboBoxScreenCapture";
            this.comboBoxScreenCapture.Size = new System.Drawing.Size(54, 21);
            this.comboBoxScreenCapture.TabIndex = 210;
            this.comboBoxScreenCapture.Text = "S";
            this.toolTip.SetToolTip(this.comboBoxScreenCapture, "按下快捷键，按住鼠标左键拖动选择屏幕区域，松手完成截屏。");
            this.comboBoxScreenCapture.TextChanged += new System.EventHandler(this.ComboBoxScreenCapture_TextChanged);
            // 
            // checkBoxSameSubNet
            // 
            this.checkBoxSameSubNet.AutoSize = true;
            this.checkBoxSameSubNet.Location = new System.Drawing.Point(9, 162);
            this.checkBoxSameSubNet.Name = "checkBoxSameSubNet";
            this.checkBoxSameSubNet.Size = new System.Drawing.Size(114, 18);
            this.checkBoxSameSubNet.TabIndex = 175;
            this.checkBoxSameSubNet.Text = "仅限内网控制";
            this.toolTip.SetToolTip(this.checkBoxSameSubNet, "仅允许连接到同一内网 NNN.NNN.*.* 下的电脑，只支持 IPv4。");
            this.checkBoxSameSubNet.UseCompatibleTextRendering = true;
            this.checkBoxSameSubNet.UseVisualStyleBackColor = true;
            this.checkBoxSameSubNet.CheckedChanged += new System.EventHandler(this.CheckBoxSameSubNet_CheckedChanged);
            // 
            // checkBoxClipNetStatus
            // 
            this.checkBoxClipNetStatus.AutoSize = true;
            this.checkBoxClipNetStatus.Location = new System.Drawing.Point(268, 119);
            this.checkBoxClipNetStatus.Name = "checkBoxClipNetStatus";
            this.checkBoxClipNetStatus.Size = new System.Drawing.Size(231, 18);
            this.checkBoxClipNetStatus.TabIndex = 176;
            this.checkBoxClipNetStatus.Text = "显示剪贴板/网络活动通知(&N)";
            this.toolTip.SetToolTip(this.checkBoxClipNetStatus, "剪贴板和网络状态发生变化时，发送系统通知。");
            this.checkBoxClipNetStatus.UseCompatibleTextRendering = true;
            this.checkBoxClipNetStatus.UseVisualStyleBackColor = true;
            this.checkBoxClipNetStatus.CheckedChanged += new System.EventHandler(this.CheckBoxClipNetStatus_CheckedChanged);
            // 
            // checkBoxSendLog
            // 
            this.checkBoxSendLog.AutoSize = true;
            this.checkBoxSendLog.Location = new System.Drawing.Point(268, 142);
            this.checkBoxSendLog.Name = "checkBoxSendLog";
            this.checkBoxSendLog.Size = new System.Drawing.Size(95, 18);
            this.checkBoxSendLog.TabIndex = 177;
            this.checkBoxSendLog.Text = "发送错误日志(&E)";
            this.toolTip.SetToolTip(this.checkBoxSendLog, "发送匿名错误日志到微软车库来帮助改进本软件。");
            this.checkBoxSendLog.UseCompatibleTextRendering = true;
            this.checkBoxSendLog.UseVisualStyleBackColor = true;
            this.checkBoxSendLog.Visible = false;
            this.checkBoxSendLog.CheckedChanged += new System.EventHandler(this.CheckBoxSendLog_CheckedChanged);
            // 
            // groupBoxKeySetup
            // 
            this.groupBoxKeySetup.Controls.Add(this.buttonNewKey);
            this.groupBoxKeySetup.Controls.Add(this.textBoxEnc);
            this.groupBoxKeySetup.Controls.Add(this.LabelEnc);
            this.groupBoxKeySetup.Controls.Add(this.checkBoxShowKey);
            this.groupBoxKeySetup.Location = new System.Drawing.Point(3, 6);
            this.groupBoxKeySetup.Name = "groupBoxKeySetup";
            this.groupBoxKeySetup.Size = new System.Drawing.Size(558, 66);
            this.groupBoxKeySetup.TabIndex = 0;
            this.groupBoxKeySetup.TabStop = false;
            this.groupBoxKeySetup.Text = " 连接(&S)";
            this.toolTip.SetToolTip(this.groupBoxKeySetup, "数据通信使用该密码加密。");
            // 
            // buttonNewKey
            // 
            this.buttonNewKey.Location = new System.Drawing.Point(471, 19);
            this.buttonNewKey.Name = "buttonNewKey";
            this.buttonNewKey.Size = new System.Drawing.Size(75, 23);
            this.buttonNewKey.TabIndex = 22;
            this.buttonNewKey.Text = "生成(&K)";
            this.buttonNewKey.UseVisualStyleBackColor = true;
            this.buttonNewKey.Click += new System.EventHandler(this.ButtonNewKey_Click);
            // 
            // textBoxEnc
            // 
            this.textBoxEnc.Location = new System.Drawing.Point(86, 19);
            this.textBoxEnc.MaxLength = 22;
            this.textBoxEnc.Name = "textBoxEnc";
            this.textBoxEnc.PasswordChar = '*';
            this.textBoxEnc.Size = new System.Drawing.Size(304, 20);
            this.textBoxEnc.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxEnc, "密码必须自动生成，不可以手动输入。将密码输入到其他设备建立连接。");
            // 
            // LabelEnc
            // 
            this.LabelEnc.AutoSize = true;
            this.LabelEnc.Location = new System.Drawing.Point(7, 25);
            this.LabelEnc.Name = "LabelEnc";
            this.LabelEnc.Size = new System.Drawing.Size(69, 13);
            this.LabelEnc.TabIndex = 19;
            this.LabelEnc.Text = "密码:";
            // 
            // checkBoxShowKey
            // 
            this.checkBoxShowKey.AutoSize = true;
            this.checkBoxShowKey.Location = new System.Drawing.Point(396, 21);
            this.checkBoxShowKey.Name = "checkBoxShowKey";
            this.checkBoxShowKey.Size = new System.Drawing.Size(73, 17);
            this.checkBoxShowKey.TabIndex = 4;
            this.checkBoxShowKey.Text = "显示(&S)";
            this.checkBoxShowKey.UseVisualStyleBackColor = true;
            this.checkBoxShowKey.CheckedChanged += new System.EventHandler(this.CheckBoxShowKey_CheckedChanged);
            // 
            // labelEasyMouse
            // 
            this.labelEasyMouse.AutoSize = true;
            this.labelEasyMouse.Location = new System.Drawing.Point(309, 98);
            this.labelEasyMouse.Name = "labelEasyMouse";
            this.labelEasyMouse.Size = new System.Drawing.Size(68, 13);
            this.labelEasyMouse.TabIndex = 211;
            this.labelEasyMouse.Text = "易动模式:";
            this.toolTip.SetToolTip(this.labelEasyMouse, "如果易动不选择常开，你也可以选择按住 Ctrl 或 Shift 来快速移动到其他电脑。");
            // 
            // comboBoxEasyMouseOption
            // 
            this.comboBoxEasyMouseOption.Enabled = true;
            this.comboBoxEasyMouseOption.FormattingEnabled = true;
            this.comboBoxEasyMouseOption.Items.AddRange(new object[] {
            "开启",
            "Ctrl",
            "Shift",
            "关闭"});
            this.comboBoxEasyMouseOption.Location = new System.Drawing.Point(490, 94);
            this.comboBoxEasyMouseOption.Name = "comboBoxEasyMouseOption";
            this.comboBoxEasyMouseOption.Size = new System.Drawing.Size(56, 21);
            this.comboBoxEasyMouseOption.TabIndex = 212;
            this.comboBoxEasyMouseOption.Text = "开启";
            this.toolTip.SetToolTip(this.comboBoxEasyMouseOption, "移动鼠标到屏幕边缘即可跨电脑移动。");
            this.comboBoxEasyMouseOption.TextChanged += new System.EventHandler(this.ComboBoxEasyMouseOption_TextChanged);
            // 
            // checkBoxTransferFile
            // 
            this.checkBoxTransferFile.AutoSize = true;
            this.checkBoxTransferFile.Checked = true;
            this.checkBoxTransferFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTransferFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTransferFile.Location = new System.Drawing.Point(26, 51);
            this.checkBoxTransferFile.Name = "checkBoxTransferFile";
            this.checkBoxTransferFile.Size = new System.Drawing.Size(81, 17);
            this.checkBoxTransferFile.TabIndex = 178;
            this.checkBoxTransferFile.Text = "自动传输文件(&T)";
            this.toolTip.SetToolTip(this.checkBoxTransferFile, "共享复制的文件，复制文件小于 100MB 时，自动传输到别的电脑的剪贴板。");
            this.checkBoxTransferFile.UseVisualStyleBackColor = true;
            this.checkBoxTransferFile.CheckedChanged += new System.EventHandler(this.CheckBoxTransferFile_CheckedChanged);
            // 
            // toolTipManual
            // 
            this.toolTipManual.ToolTipTitle = "Microsoft® Visual Studio® 2010";
            // 
            // tabPageOther
            // 
            this.tabPageOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.tabPageOther.Controls.Add(this.groupBoxOtherOptions);
            this.tabPageOther.Controls.Add(this.groupBoxShortcuts);
            this.tabPageOther.Location = new System.Drawing.Point(4, 25);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOther.Size = new System.Drawing.Size(563, 362);
            this.tabPageOther.TabIndex = 1;
            this.tabPageOther.Text = "配置";
            // 
            // groupBoxOtherOptions
            // 
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxTransferFile);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxSendLog);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxClipNetStatus);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxSameSubNet);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxVKMap);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxReverseLookup);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxDrawMouse);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxMouseMoveRelatively);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxHideMouse);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxBlockMouseAtCorners);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxCircle);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxBlockScreenSaver);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxHideLogo);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxShareClipboard);
            this.groupBoxOtherOptions.Controls.Add(this.checkBoxDisableCAD);
            this.groupBoxOtherOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOtherOptions.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOtherOptions.Name = "groupBoxOtherOptions";
            this.groupBoxOtherOptions.Size = new System.Drawing.Size(557, 189);
            this.groupBoxOtherOptions.TabIndex = 163;
            this.groupBoxOtherOptions.TabStop = false;
            // 
            // groupBoxShortcuts
            // 
            this.groupBoxShortcuts.Controls.Add(this.comboBoxEasyMouseOption);
            this.groupBoxShortcuts.Controls.Add(this.labelEasyMouse);
            this.groupBoxShortcuts.Controls.Add(this.comboBoxScreenCapture);
            this.groupBoxShortcuts.Controls.Add(this.labelScreenCapture);
            this.groupBoxShortcuts.Controls.Add(this.comboBoxEasyMouse);
            this.groupBoxShortcuts.Controls.Add(this.LabelToggleEasyMouse);
            this.groupBoxShortcuts.Controls.Add(this.comboBoxReconnect);
            this.groupBoxShortcuts.Controls.Add(this.comboBoxSwitchToAllPC);
            this.groupBoxShortcuts.Controls.Add(this.comboBoxExitMM);
            this.groupBoxShortcuts.Controls.Add(this.comboBoxLockMachine);
            this.groupBoxShortcuts.Controls.Add(this.comboBoxShowSettings);
            this.groupBoxShortcuts.Controls.Add(this.labelReconnect);
            this.groupBoxShortcuts.Controls.Add(this.labelSwitch2AllPCMode);
            this.groupBoxShortcuts.Controls.Add(this.radioButtonDisable);
            this.groupBoxShortcuts.Controls.Add(this.radioButtonNum);
            this.groupBoxShortcuts.Controls.Add(this.radioButtonF1);
            this.groupBoxShortcuts.Controls.Add(this.labelLockMachine);
            this.groupBoxShortcuts.Controls.Add(this.labelExitMM);
            this.groupBoxShortcuts.Controls.Add(this.labelShowSettings);
            this.groupBoxShortcuts.Controls.Add(this.labelSwitchBetweenMachine);
            this.groupBoxShortcuts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxShortcuts.Location = new System.Drawing.Point(3, 198);
            this.groupBoxShortcuts.Name = "groupBoxShortcuts";
            this.groupBoxShortcuts.Size = new System.Drawing.Size(557, 161);
            this.groupBoxShortcuts.TabIndex = 200;
            this.groupBoxShortcuts.TabStop = false;
            this.groupBoxShortcuts.Text = " 快捷键(&K) ";


            ToolTip groupBoxToolTip = new ToolTip();
            groupBoxToolTip.SetToolTip(this.groupBoxShortcuts, "以下设置由 PowerToys 设置界面控制.");

            foreach (Control control in this.groupBoxShortcuts.Controls)
            {
                control.Enabled = false;
            }

            // 
            // labelScreenCapture
            // 
            this.labelScreenCapture.AutoSize = true;
            this.labelScreenCapture.Location = new System.Drawing.Point(6, 124);
            this.labelScreenCapture.Name = "labelScreenCapture";
            this.labelScreenCapture.Size = new System.Drawing.Size(173, 13);
            this.labelScreenCapture.TabIndex = 209;
            this.labelScreenCapture.Text = "区块截屏 Ctrl+Shift+:";
            // 
            // LabelToggleEasyMouse
            // 
            this.LabelToggleEasyMouse.AutoSize = true;
            this.LabelToggleEasyMouse.Location = new System.Drawing.Point(309, 125);
            this.LabelToggleEasyMouse.Name = "LabelToggleEasyMouse";
            this.LabelToggleEasyMouse.Size = new System.Drawing.Size(149, 13);
            this.LabelToggleEasyMouse.TabIndex = 114;
            this.LabelToggleEasyMouse.Text = "切换易动 Ctrl+Alt+:";
            // 
            // comboBoxExitMM
            // 
            this.comboBoxExitMM.Enabled = false;
            this.comboBoxExitMM.FormattingEnabled = true;
            this.comboBoxExitMM.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "关闭"});
            this.comboBoxExitMM.Location = new System.Drawing.Point(490, 41);
            this.comboBoxExitMM.Name = "comboBoxExitMM";
            this.comboBoxExitMM.Size = new System.Drawing.Size(56, 21);
            this.comboBoxExitMM.TabIndex = 204;
            this.comboBoxExitMM.Text = "Q";
            this.comboBoxExitMM.TextChanged += new System.EventHandler(this.ComboBoxExitMM_TextChanged);
            // 
            // comboBoxShowSettings
            // 
            this.comboBoxShowSettings.Enabled = false;
            this.comboBoxShowSettings.FormattingEnabled = true;
            this.comboBoxShowSettings.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "关闭"});
            this.comboBoxShowSettings.Location = new System.Drawing.Point(230, 41);
            this.comboBoxShowSettings.Name = "comboBoxShowSettings";
            this.comboBoxShowSettings.Size = new System.Drawing.Size(54, 21);
            this.comboBoxShowSettings.TabIndex = 203;
            this.comboBoxShowSettings.Text = "M";
            this.comboBoxShowSettings.TextChanged += new System.EventHandler(this.ComboBoxShowSettings_TextChanged);
            // 
            // labelReconnect
            // 
            this.labelReconnect.AutoSize = true;
            this.labelReconnect.Location = new System.Drawing.Point(6, 98);
            this.labelReconnect.Name = "labelReconnect";
            this.labelReconnect.Size = new System.Drawing.Size(195, 13);
            this.labelReconnect.TabIndex = 59;
            this.labelReconnect.Text = "刷新连接 Ctrl+Alt+:";
            // 
            // labelSwitch2AllPCMode
            // 
            this.labelSwitch2AllPCMode.AutoSize = true;
            this.labelSwitch2AllPCMode.Location = new System.Drawing.Point(309, 71);
            this.labelSwitch2AllPCMode.Name = "labelSwitch2AllPCMode";
            this.labelSwitch2AllPCMode.Size = new System.Drawing.Size(122, 13);
            this.labelSwitch2AllPCMode.TabIndex = 33;
            this.labelSwitch2AllPCMode.Text = "同步模式:";
            // 
            // radioButtonDisable
            // 
            this.radioButtonDisable.AutoSize = true;
            this.radioButtonDisable.Location = new System.Drawing.Point(434, 14);
            this.radioButtonDisable.Name = "radioButtonDisable";
            this.radioButtonDisable.Size = new System.Drawing.Size(60, 17);
            this.radioButtonDisable.TabIndex = 202;
            this.radioButtonDisable.TabStop = true;
            this.radioButtonDisable.Text = "关闭(&D)";
            this.radioButtonDisable.UseVisualStyleBackColor = true;
            this.radioButtonDisable.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonNum
            // 
            this.radioButtonNum.AutoSize = true;
            this.radioButtonNum.Location = new System.Drawing.Point(346, 15);
            this.radioButtonNum.Name = "radioButtonNum";
            this.radioButtonNum.Size = new System.Drawing.Size(67, 17);
            this.radioButtonNum.TabIndex = 201;
            this.radioButtonNum.TabStop = true;
            this.radioButtonNum.Text = "&1, 2, 3, 4";
            this.radioButtonNum.UseVisualStyleBackColor = true;
            this.radioButtonNum.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonF1
            // 
            this.radioButtonF1.AutoSize = true;
            this.radioButtonF1.Location = new System.Drawing.Point(230, 14);
            this.radioButtonF1.Name = "radioButtonF1";
            this.radioButtonF1.Size = new System.Drawing.Size(91, 17);
            this.radioButtonF1.TabIndex = 200;
            this.radioButtonF1.TabStop = true;
            this.radioButtonF1.Text = "&F1, F2, F3, F4";
            this.radioButtonF1.UseVisualStyleBackColor = true;
            this.radioButtonF1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // labelLockMachine
            // 
            this.labelLockMachine.AutoSize = true;
            this.labelLockMachine.Location = new System.Drawing.Point(6, 71);
            this.labelLockMachine.Name = "labelLockMachine";
            this.labelLockMachine.Size = new System.Drawing.Size(133, 13);
            this.labelLockMachine.TabIndex = 31;
            this.labelLockMachine.Text = "全部锁屏 Ctrl+Alt+:";
            // 
            // labelExitMM
            // 
            this.labelExitMM.AutoSize = true;
            this.labelExitMM.Location = new System.Drawing.Point(309, 44);
            this.labelExitMM.Name = "labelExitMM";
            this.labelExitMM.Size = new System.Drawing.Size(138, 13);
            this.labelExitMM.TabIndex = 29;
            this.labelExitMM.Text = "退出软件 Ctrl+Alt+Shift+:";
            // 
            // labelShowSettings
            // 
            this.labelShowSettings.AutoSize = true;
            this.labelShowSettings.Location = new System.Drawing.Point(6, 44);
            this.labelShowSettings.Name = "labelShowSettings";
            this.labelShowSettings.Size = new System.Drawing.Size(149, 13);
            this.labelShowSettings.TabIndex = 27;
            this.labelShowSettings.Text = "打开设置 Ctrl+Alt+:";
            // 
            // labelSwitchBetweenMachine
            // 
            this.labelSwitchBetweenMachine.AutoSize = true;
            this.labelSwitchBetweenMachine.Location = new System.Drawing.Point(6, 18);
            this.labelSwitchBetweenMachine.Name = "labelSwitchBetweenMachine";
            this.labelSwitchBetweenMachine.Size = new System.Drawing.Size(179, 13);
            this.labelSwitchBetweenMachine.TabIndex = 24;
            this.labelSwitchBetweenMachine.Text = "切换设备 Ctrl+Alt+:";
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.tabPageMain.Controls.Add(this.buttonCancel);
            this.tabPageMain.Controls.Add(this.groupBoxMachineMatrix);
            this.tabPageMain.Controls.Add(this.groupBoxKeySetup);
            this.tabPageMain.Controls.Add(this.buttonOK);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(563, 362);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "设备";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(290, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "关闭(&C)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // groupBoxMachineMatrix
            // 
            this.groupBoxMachineMatrix.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMachineMatrix.Controls.Add(this.checkBoxTwoRow);
            this.groupBoxMachineMatrix.Controls.Add(this.linkLabelReConfigure);
            this.groupBoxMachineMatrix.Location = new System.Drawing.Point(3, 78);
            this.groupBoxMachineMatrix.Name = "groupBoxMachineMatrix";
            this.groupBoxMachineMatrix.Size = new System.Drawing.Size(558, 244);
            this.groupBoxMachineMatrix.TabIndex = 5;
            this.groupBoxMachineMatrix.TabStop = false;
            this.groupBoxMachineMatrix.Text = " 设备布局(&M) - 拖动设备图标排序，选中图标旁边的勾选框以输入设备名称。 ";
            // 
            // linkLabelReConfigure
            // 
            this.linkLabelReConfigure.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabelReConfigure.Location = new System.Drawing.Point(3, 221);
            this.linkLabelReConfigure.Name = "linkLabelReConfigure";
            this.linkLabelReConfigure.Size = new System.Drawing.Size(552, 20);
            this.linkLabelReConfigure.TabIndex = 304;
            this.linkLabelReConfigure.TabStop = true;
            this.linkLabelReConfigure.Text = "重新执行软件初始化";
            this.linkLabelReConfigure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelReConfigure.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelReConfigure_LinkClicked);
            // 
            // tabControlSetting
            // 
            this.tabControlSetting.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlSetting.Controls.Add(this.tabPageMain);
            this.tabControlSetting.Controls.Add(this.tabPageOther);
            this.tabControlSetting.Controls.Add(this.tabPageAdvancedSettings);
            this.tabControlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSetting.Location = new System.Drawing.Point(0, 0);
            this.tabControlSetting.Name = "tabControlSetting";
            this.tabControlSetting.SelectedIndex = 0;
            this.tabControlSetting.Size = new System.Drawing.Size(571, 391);
            this.tabControlSetting.TabIndex = 20;
            // 
            // tabPageAdvancedSettings
            // 
            this.tabPageAdvancedSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.tabPageAdvancedSettings.Controls.Add(this.pictureBoxMouseWithoutBorders);
            this.tabPageAdvancedSettings.Controls.Add(this.groupBoxDNS);
            this.tabPageAdvancedSettings.Controls.Add(this.textBoxDNS);
            this.tabPageAdvancedSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdvancedSettings.Name = "tabPageAdvancedSettings";
            this.tabPageAdvancedSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvancedSettings.Size = new System.Drawing.Size(563, 362);
            this.tabPageAdvancedSettings.TabIndex = 2;
            this.tabPageAdvancedSettings.Text = "高级";
            // 
            // pictureBoxMouseWithoutBorders
            // 
            this.pictureBoxMouseWithoutBorders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxMouseWithoutBorders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxMouseWithoutBorders.Location = new System.Drawing.Point(3, 241);
            this.pictureBoxMouseWithoutBorders.Name = "pictureBoxMouseWithoutBorders";
            this.pictureBoxMouseWithoutBorders.Size = new System.Drawing.Size(557, 118);
            this.pictureBoxMouseWithoutBorders.TabIndex = 16;
            this.pictureBoxMouseWithoutBorders.TabStop = false;
            // 
            // groupBoxDNS
            // 
            this.groupBoxDNS.Controls.Add(this.textBoxMachineName2IP);
            this.groupBoxDNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDNS.Location = new System.Drawing.Point(3, 85);
            this.groupBoxDNS.Name = "groupBoxDNS";
            this.groupBoxDNS.Size = new System.Drawing.Size(557, 150);
            this.groupBoxDNS.TabIndex = 0;
            this.groupBoxDNS.TabStop = false;
            this.groupBoxDNS.Text = " IP 地址映射 ";
            // 
            // textBoxMachineName2IP
            // 
            this.textBoxMachineName2IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMachineName2IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMachineName2IP.Location = new System.Drawing.Point(3, 16);
            this.textBoxMachineName2IP.MaxLength = 1024;
            this.textBoxMachineName2IP.Multiline = true;
            this.textBoxMachineName2IP.Name = "textBoxMachineName2IP";
            this.textBoxMachineName2IP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMachineName2IP.Size = new System.Drawing.Size(551, 131);
            this.textBoxMachineName2IP.TabIndex = 0;
            // 
            // textBoxDNS
            // 
            this.textBoxDNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.textBoxDNS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDNS.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxDNS.Location = new System.Drawing.Point(3, 3);
            this.textBoxDNS.Multiline = true;
            this.textBoxDNS.Name = "textBoxDNS";
            this.textBoxDNS.ReadOnly = true;
            this.textBoxDNS.Size = new System.Drawing.Size(557, 82);
            this.textBoxDNS.TabIndex = 0;
            this.textBoxDNS.TabStop = false;
            this.textBoxDNS.Text = resources.GetString("textBoxDNS.Text");
            // 
            // linkLabelHelp
            // 
            this.linkLabelHelp.AutoSize = true;
            this.linkLabelHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabelHelp.Location = new System.Drawing.Point(400, 0);
            this.linkLabelHelp.Name = "linkLabelHelp";
            this.linkLabelHelp.Size = new System.Drawing.Size(124, 13);
            this.linkLabelHelp.TabIndex = 300;
            this.linkLabelHelp.TabStop = true;
            this.linkLabelHelp.Text = "在线帮助(&H)";
            this.linkLabelHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelHelp_LinkClicked);
            // 
            // linkLabelMiniLog
            // 
            this.linkLabelMiniLog.AutoSize = true;
            this.linkLabelMiniLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabelMiniLog.Location = new System.Drawing.Point(524, 0);
            this.linkLabelMiniLog.Name = "linkLabelMiniLog";
            this.linkLabelMiniLog.Size = new System.Drawing.Size(47, 13);
            this.linkLabelMiniLog.TabIndex = 301;
            this.linkLabelMiniLog.TabStop = true;
            this.linkLabelMiniLog.Text = "运行日志";
            this.linkLabelMiniLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelMiniLog_LinkClicked);
            // 
            // frmMatrix
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(571, 391);
            this.Controls.Add(this.linkLabelHelp);
            this.Controls.Add(this.linkLabelMiniLog);
            this.Controls.Add(this.tabControlSetting);
            this.Controls.Add(this.pictureBoxMouseWithoutBorders0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "无界鼠标 - 设置";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMatrix_FormClosed);
            this.Load += new System.EventHandler(this.FrmMatrix_Load);
            this.Shown += new System.EventHandler(this.FrmMatrix_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.Form_DragOver);
            this.DragLeave += new System.EventHandler(this.FrmMatrix_DragLeave);
            this.Resize += new System.EventHandler(this.FrmMatrix_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseWithoutBorders0)).EndInit();
            this.groupBoxKeySetup.ResumeLayout(false);
            this.groupBoxKeySetup.PerformLayout();
            this.tabPageOther.ResumeLayout(false);
            this.groupBoxOtherOptions.ResumeLayout(false);
            this.groupBoxOtherOptions.PerformLayout();
            this.groupBoxShortcuts.ResumeLayout(false);
            this.groupBoxShortcuts.PerformLayout();
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxMachineMatrix.ResumeLayout(false);
            this.groupBoxMachineMatrix.PerformLayout();
            this.tabControlSetting.ResumeLayout(false);
            this.tabPageAdvancedSettings.ResumeLayout(false);
            this.tabPageAdvancedSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouseWithoutBorders)).EndInit();
            this.groupBoxDNS.ResumeLayout(false);
            this.groupBoxDNS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxMouseWithoutBorders0;
        private ToolTip toolTip;
        private ToolTip toolTipManual;
        private TabPage tabPageOther;
        private GroupBox groupBoxShortcuts;
        private ComboBox comboBoxReconnect;
        private ComboBox comboBoxSwitchToAllPC;
        private ComboBox comboBoxExitMM;
        private ComboBox comboBoxLockMachine;
        private ComboBox comboBoxShowSettings;
        private Label labelReconnect;
        private Label labelSwitch2AllPCMode;
        private RadioButton radioButtonDisable;
        private RadioButton radioButtonNum;
        private RadioButton radioButtonF1;
        private Label labelLockMachine;
        private Label labelExitMM;
        private Label labelShowSettings;
        private Label labelSwitchBetweenMachine;
        private TabPage tabPageMain;
        private Button buttonCancel;
        private GroupBox groupBoxMachineMatrix;
        private CheckBox checkBoxTwoRow;
        private Button buttonOK;
        private TabControl tabControlSetting;
        private ComboBox comboBoxEasyMouse;
        private Label LabelToggleEasyMouse;
        private LinkLabel linkLabelHelp;
        private TabPage tabPageAdvancedSettings;
        private GroupBox groupBoxDNS;
        private TextBox textBoxDNS;
        private TextBox textBoxMachineName2IP;
        private PictureBox pictureBoxMouseWithoutBorders;
        private GroupBox groupBoxOtherOptions;
        private CheckBox checkBoxDrawMouse;
        private CheckBox checkBoxMouseMoveRelatively;
        private CheckBox checkBoxHideMouse;
        private CheckBox checkBoxBlockMouseAtCorners;
        private CheckBox checkBoxCircle;
        private CheckBox checkBoxBlockScreenSaver;
        private CheckBox checkBoxHideLogo;
        private CheckBox checkBoxShareClipboard;
        private CheckBox checkBoxDisableCAD;
        private CheckBox checkBoxReverseLookup;
        private CheckBox checkBoxVKMap;
        private LinkLabel linkLabelMiniLog;
        private ComboBox comboBoxScreenCapture;
        private Label labelScreenCapture;
        private LinkLabel linkLabelReConfigure;
        private CheckBox checkBoxSameSubNet;
        private CheckBox checkBoxClipNetStatus;
        private CheckBox checkBoxSendLog;
        private GroupBox groupBoxKeySetup;
        private Button buttonNewKey;
        private TextBox textBoxEnc;
        private Label LabelEnc;
        private CheckBox checkBoxShowKey;
        private ComboBox comboBoxEasyMouseOption;
        private Label labelEasyMouse;
        private CheckBox checkBoxTransferFile;
    }
}