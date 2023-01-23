// ------------------------------------------------------------------------------
//                    Copyright (c) 2021 Medtronic, Inc.
// This software is copyrighted by and is the sole property of Medtronic/Covidien. This
// is a proprietary work to which Medtronic/Covidien claims exclusive right.  No part
// of this work may be used, disclosed, reproduced, stored in an information
// retrieval system, or transmitted by any means, electronic, mechanical,
// photocopying, recording, or otherwise without the prior written permission
// of Medtronic/Covidien.
// ------------------------------------------------------------------------------

namespace SpecFlow.Specs.WpfExampleApp
{
    using OpenQA.Selenium.Appium.Windows;

    using SpecFlow.Actions.WindowsAppDriver;

    public class MainWindowElements
    {
        protected readonly AppDriver appDriver;

        public MainWindowElements(AppDriver appDriver)
        {
            this.appDriver = appDriver;
        }

        public WindowsElement ClickMeButton =>
           appDriver.Current.FindElementByAccessibilityId("btnClickMe");

        public WindowsElement ResultTextBox =>
           appDriver.Current.FindElementByAccessibilityId("result");
    }
}