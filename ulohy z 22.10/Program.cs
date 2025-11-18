Animal bylinozravec = new Animal();
bylinozravec.setfood(true);
Animal masozravec = new Animal();
masozravec.setfood(false);
bylinozravec.CanEatOtherAnimal();
bool MozeBylinozravecJest = bylinozravec.CanEatOtherAnimal();
bool MozeMasozravecJest = masozravec.CanEatOtherAnimal();
Console.WriteLine($"bylinozravec{MozeBylinozravecJest}");
Console.WriteLine($"masozravec{MozeMasozravecJest}");
