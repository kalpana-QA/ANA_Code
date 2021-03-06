﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ANA.RecoderModules
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The HomePage recording.
    /// </summary>
    [TestModule("a420403c-9cd9-4b61-bd6a-1d9fc43786e2", ModuleType.Recording, 1)]
    public partial class HomePage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::ANA.ANARepository repository.
        /// </summary>
        public static global::ANA.ANARepository repo = global::ANA.ANARepository.Instance;

        static HomePage instance = new HomePage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HomePage()
        {
            email_address = "";
            password = "Test123";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HomePage Instance
        {
            get { return instance; }
        }

#region Variables

        string _email_address;

        /// <summary>
        /// Gets or sets the value of variable email_address.
        /// </summary>
        [TestVariable("f72203e7-48f7-4596-bd65-cad42556083d")]
        public string email_address
        {
            get { return _email_address; }
            set { _email_address = value; }
        }

        string _password;

        /// <summary>
        /// Gets or sets the value of variable password.
        /// </summary>
        [TestVariable("a27a33a5-62f4-45ca-a29a-75bc29ed071c")]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            // User click on join ANA
            Report.Log(ReportLevel.Info, "Mouse", "User click on join ANA\r\nMouse Left Click item 'ApplicationUnderTest.JoinANA' at Center.", repo.ApplicationUnderTest.JoinANAInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.JoinANA.Click();
            Delay.Milliseconds(0);
            
            // Join Us Today
            Report.Log(ReportLevel.Info, "Mouse", "Join Us Today\r\nMouse Left Click item 'ApplicationUnderTest.JOINUSTODAY' at Center.", repo.ApplicationUnderTest.JOINUSTODAYInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.JOINUSTODAY.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$email_address' with focus on 'TxtEmail'.", repo.TxtEmailInfo, new RecordItemIndex(2));
            repo.TxtEmail.PressKeys(email_address);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BtnNext' at Center.", repo.BtnNextInfo, new RecordItemIndex(3));
            repo.BtnNext.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
