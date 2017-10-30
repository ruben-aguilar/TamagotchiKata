using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TamagotchiKata;
using TechTalk.SpecFlow;

namespace TamagotchiKataFeatures
{
    [Binding]
    public class TamagochiOwnerCanPutInBedSteps
    {
        Tamagotchi tamagotchi;
        int tiredness;

        [Given(@"I have a tired Tamagotchi")]
        public void GivenIHaveATiredTamagotchi()
        {
            tamagotchi = new Tamagotchi();
            tiredness = tamagotchi.Tiredness;
        }
        
        [When(@"I put it to bed")]
        public void WhenIPutItToBed()
        {
            tamagotchi.PutToBed();
        }
        
        [Then(@"it's tiredness is decreased")]
        public void ThenItSTirednessIsDecreased()
        {
            Assert.IsTrue(tamagotchi.Tiredness < tiredness);
        }
    }
}
