//trieda animal
//2 zvierata
// 1. mesozravec
//2. bylinozravec
// bylino zje ine zviera
//mesozrav zje ine zviera



using simulacia;

Animal bylinozravec = new Animal();
bylinozravec.setfood(true);
Animal mesozravec = new Animal();
mesozravec.setfood(false);
bylinozravec.CanEatOtherAnimal();
bool MozeBylinozravecJest = bylinozravec.CanEatOtherAnimal();
bool MozeMesozravecJest = mesozravec.CanEatOtherAnimal();
Console.WriteLine($" bylinozravec {MozeBylinozravecJest}");
Console.WriteLine($" mesozravec {MozeMesozravecJest}");
