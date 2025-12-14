// trieda Animal
// 2 zvierata
// 1th zviera will be mesozravec
//2th bilinovraver
//bylono, ziest ine zviera
//mesokrava zie ine zviera



using Fafafela;

//the sistering thing in the Fafafela, but not really, idk
Animal bylinozravec =  new Animal();

//metoda
bylinozravec.setFood(true);

Animal mesozravec = new Animal();
mesozravec.setFood(false);

bool mozeBylinozravecJest = bylinozravec.CanEatOtherAnimal();
bool mozeMesozravecJest = mesozravec.CanEatOtherAnimal();

Console.WriteLine($"byli:{mozeBylinozravecJest}, Meso:{mozeMesozravecJest}");