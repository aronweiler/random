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
    using SpecFlow.Actions.WindowsAppDriver;

    public class MainWindow : MainWindowElements
    {
        public MainWindow(AppDriver appDriver) : base(appDriver)
        {
        }

        public void ClickButton()
        {
            ClickMeButton.Click();
        }

        public string GetResultText()
        {
            return ResultTextBox.Text;
        }

        public void SetResultText(string result)
        {
            ResultTextBox.SendKeys(result);
        }
    }
}