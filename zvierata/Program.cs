


 
        Animal bylinoyravec = new Animal();
        bylinoyravec.Setfood(true);
        Animal masozravec = new Animal();
        masozravec.Setfood(false);
        bool Mozebylinozravecjest = bylinoyravec.CanEatOtherAnimal();
        bool Mozemasozravecjest = masozravec.CanEatOtherAnimal();
        Console.WriteLine($"bylinozravec{Mozebylinozravecjest}");
        Console.WriteLine($"masozravec{Mozemasozravecjest}");
    

