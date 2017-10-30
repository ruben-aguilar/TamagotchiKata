using System;
using TechTalk.SpecFlow;
using TamagotchiKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TamagotchiKataFeatures
{
    [Binding]
    public class TamagochiOwnerCanPlayWithItSteps
    {
        private Tamagotchi tamagotchi;
        private int happiness;
        private int tiredness;

        [Given(@"I have a bored Tamagotchi")]
        public void GivenIHaveABoredTamagotchi()
        {
            tamagotchi = new Tamagotchi();
            happiness = tamagotchi.Happiness;
            tiredness = tamagotchi.Tiredness;
        }
        
        [When(@"I play with it")]
        public void WhenIPlayWithIt()
        {
            tamagotchi.Play();
        }
        
        [Then(@"it's happiness is increased")]
        public void ThenItSHappinessIsIncreased()
        {
            Assert.IsTrue(tamagotchi.Happiness > happiness);
        }
        
        [Then(@"it's tiredness is increased")]
        public void ThenItSTirednessIsIncreased()
        {
            Assert.IsTrue(tamagotchi.Tiredness > tiredness);
        }
    }
}
