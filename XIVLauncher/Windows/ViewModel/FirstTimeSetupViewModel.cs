﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheapLoc;

namespace XIVLauncher.Windows.ViewModel
{
    class FirstTimeSetupViewModel
    {
        public FirstTimeSetupViewModel()
        {
            SetupLoc();
        }

        public void SetupLoc()
        {
            FirstTimeGamePathLoc = Loc.Localize("ChooseGamePath",
                "Please select the folder your game is installed in.\r\nIt should contain the folders \"game\" and \"boot\".");
            FirstTimeSteamNoticeLoc = Loc.Localize("FirstTimeSteamNotice",
                "Please check this box if you are usually launching the game using Steam.");
            FirstTimeSteamCheckBoxLoc = Loc.Localize("FirstTimeSteamCheckBox", "Enable Steam integration");
            FirstTimeDirectXLoc = Loc.Localize("ChooseDirectX", "Please select which DirectX version you want to use.");
            DirectX9NoticeLoc = Loc.Localize("DirectX9Notice",
                "DirectX 9 mode is not supported anymore. It will still start, but you will not get support from\r\nSE for any technical issues any additional XIVLauncher features such as Rich Presence and the\r\nIn-Game addon will not work.");
            FirstTimeLanguageLoc = Loc.Localize("ChooseLanguage", "Please select which language you want to load the game with.");
            FirstTimeActLaunchLoc = Loc.Localize("FirstTimeActLaunch",
                "Advanced Combat Tracker is installed on your computer.\r\nDo you want to launch it automatically when launching the game?");
            FirstTimeActLaunchCheckBoxLoc = Loc.Localize("FirstTimeActLaunchCheckBox", "Enable ACT Auto-Launch");
            NextLoc = Loc.Localize("Next", "Next");
            FirstTimeDalamudLoc = Loc.Localize("FirstTimeDalamudNotice",
                "Do you want to enable the XIVLauncher in-game features?\r\nThis will add some extra functionality to your game, such as RMT chat filtering and\r\nDiscord notifications for chat messages or Duty Finder pops.\r\n\r\nTo configure these settings, please use the XIVLauncher settings menu and switch to the\r\nin-game tab.\r\nEnabling this however could cause a false positive on your antivirus software, please\r\ncheck its settings and add any needed exclusions if you run into problems.");
            FirstTimeDalamudCheckBoxLoc = Loc.Localize("FirstTimeDalamudCheckBox", "Enable In-Game features");
        }

        public string FirstTimeGamePathLoc { get; private set; }
        public string FirstTimeSteamNoticeLoc { get; private set; }
        public string FirstTimeSteamCheckBoxLoc { get; private set; }
        public string FirstTimeDirectXLoc { get; private set; }
        public string DirectX9NoticeLoc { get; private set; }
        public string FirstTimeLanguageLoc { get; private set; }
        public string FirstTimeActLaunchLoc { get; private set; }
        public string FirstTimeActLaunchCheckBoxLoc { get; private set; }
        public string NextLoc { get; private set; }
        public string FirstTimeDalamudLoc { get; private set; }
        public string FirstTimeDalamudCheckBoxLoc { get; private set; }
    }
}
