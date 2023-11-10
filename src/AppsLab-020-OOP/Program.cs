// See https://aka.ms/new-console-template for more information

class Character :
    def __init__(self, name, health, attack_power):
        self.name = name
        self.health = health
        self.attack_power = attack_power

    def attack(self, enemy):
        enemy.defend(self.attack_power)

    def defend(self, attack_power):
        self.health -= attack_power

    def heal(self, amount):
        self.health += amount


class Enemy(Character) :
    pass


class Battle :
    @staticmethod
    def simulate_battle(character, enemy):
        print(f"Battle started between {character.name} and {enemy.name}")
        while character.health > 0 and enemy.health > 0:
            character.attack(enemy)
            print(f"{character.name} attacked {enemy.name}. {enemy.name}'s health: {enemy.health}")


            if enemy.health <= 0:
                print(f"{enemy.name} has been defeated!")
                break


            enemy.attack(character)
            print(f"{enemy.name} attacked {character.name}. {character.name}'s health: {character.health}")


            if character.health <= 0:
                print(f"{character.name} has been defeated!")
                break


if __name__ == "__main__":
    # Vytvorenie postavy a nepriateľa
    player = Character("Hero", 100, 20)
    enemy = Enemy("Evil Villain", 80, 15)

    
    Battle.simulate_battle(player, enemy)