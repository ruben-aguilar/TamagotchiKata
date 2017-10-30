Feature: Tamagochi owner can put in bed
    As a Tamagotchi owner
    I want to put my Tamagotchi to bed
    So that I can refill it's energy

  Scenario: Tamagochi Feeded
    Given I have a Tamagotchi
    When I put it to bed
    Then it's tiredness is decreased