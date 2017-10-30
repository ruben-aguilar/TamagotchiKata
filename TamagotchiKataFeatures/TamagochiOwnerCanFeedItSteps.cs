using System;
using TechTalk.SpecFlow;
using TamagotchiKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TamagotchiKataFeatures
{
    [Binding]
    public class TamagochiOwnerCanFeedItSteps
    {
        Tamagotchi tamagotchi;
        int hungriness;
        int fullness;

        [Given(@"I have a Tamagotchi")]
        public void GivenIHaveATamagotchi()
        {
            tamagotchi = new Tamagotchi();
            hungriness = tamagotchi.Hungriness;
            fullness = tamagotchi.Fullness;
        }
        
        [When(@"I feed it")]
        public void WhenIFeedIt()
        {
            tamagotchi.Feed();
        }
        
        [Then(@"it's hungriness is decreased")]
        public void ThenItSHungrinessIsDecreased()
        {
            Assert.IsTrue(tamagotchi.Hungriness < hungriness);
        }
        
        [Then(@"it's fullness is increased")]
        public void ThenItSFullnessIsIncreased()
        {
            Assert.IsTrue(tamagotchi.Fullness > fullness, "Fullness is not increased");
        }
    }
}
