﻿Feature: Tamagotchi owner can make tamagotchi poop
    As a Tamagotchi owner
    I want to make my Tamagotchi poop
    So that it is more comfortable

  Scenario: Tamagochi Feeded
    Given I have a Tamagotchi
    When I make it poop
    Then it's fullness is decreased
