// See https://aka.ms/new-console-template for more information
from abc import ABC, abstractmethod


class Item(ABC) :
    @abstractmethod
    def examine(self):
        pass


class Key(Item) :
    def examine(self):
        return "A shiny key."

class Room(ABC) :
    @abstractmethod
    def explore(self):
        pass


class MysteryRoom(Room) :
    def explore(self):
        return "You entered a mysterious room."


class Enemy(ABC) :
    @abstractmethod
    def attack(self):
        pass


class Dragon(Enemy) :
    def attack(self):
        return "The dragon breathes fire at you!"


class AdventureGame :
    def __init__(self):
        self.current_room = MysteryRoom()
        self.inventory = []

    def play(self):
        print("Welcome to the Text Adventure Game!")
        print(self.current_room.explore())

        key = Key()
        self.inventory.append(key)

        print("You found a key in the room. ", key.examine())
        print("You can check your inventory now.")

        dragon = Dragon()
        print("Oh no! A dragon appeared!")
        print(dragon.attack())

if __name__ == "__main__":
    game = AdventureGame()
    game.play()