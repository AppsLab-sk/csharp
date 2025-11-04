// trieda Animal
// 2 zvierata
// 1. bude masozrave
// 2. bude bylinozrave
// bylino zie ine zviera
// maso zie ine zviera

using OOP_2_;

Animal bylinozravec = new Animal();
bylinozravec.setfood(true);
Animal masozravec = new Animal();
masozravec.setfood(false);

bool MozeBylinozravecJest = bylinozravec.CanEatOtherAnimal();
bool MozeMasozravecJest = masozravec.CanEatOtherAnimal();
Console.WriteLine($"bylinozravec {MozeBylinozravecJest}");
Console.WriteLine($"masozravec {MozeMasozravecJest}");