// ------------------------------------------------------------------------------
//                    Copyright (c) 2021 Medtronic, Inc.
// This software is copyrighted by and is the sole property of Medtronic/Covidien. This
// is a proprietary work to which Medtronic/Covidien claims exclusive right.  No part
// of this work may be used, disclosed, reproduced, stored in an information
// retrieval system, or transmitted by any means, electronic, mechanical,
// photocopying, recording, or otherwise without the prior written permission
// of Medtronic/Covidien.
// ------------------------------------------------------------------------------

namespace SpecFlow.Specs.StepDefinitions
{
    using SpecFlow.Specs.WpfExampleApp;

    using TechTalk.SpecFlow.Assist;

    [Binding]
    public sealed class MainWindowStepDefinitions
    {
        private readonly MainWindow mainWindow;

        public MainWindowStepDefinitions(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        [Given(@"the result textbox is: '(.*)'")]
        public void SetResultTextbox(string result)
        {
            mainWindow.SetResultText(result);
        }

        [When("the button is clicked")]
        public void WhenTheButtonIsClicked()
        {
            //TODO: implement act (action) logic

            mainWindow.ClickButton();
        }

        [Then(@"the result should be: '(.*)'")]
        public void ThenTheResultShouldBe(string result)
        {
            //TODO: implement assert (verification) logic

            mainWindow.GetResultText()
                .Should()
                .Be(result);
        }

        [When(@"the button is clicked the result matches")]
        public void WhenTheButtonIsClickedTheResultMatches(Table table)
        {
            var items = table.CreateSet<MyValues>();

            items.Should().HaveCount(2);
        }
    }

    public class MyValues
    {
        public string StartingText { get; set; }

        public string ResultingText { get; set; }
    }
}