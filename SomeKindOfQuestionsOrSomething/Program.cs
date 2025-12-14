using SomeKindOfQuestionsOrSomething;

Questions questions = new Questions();
QuestionSystem questionSystem = new QuestionSystem();

Console.WriteLine("Welcome to this very intresing quiz!\n");
questions.QuestionLoop(questionSystem);


questionSystem.FileThingIg();
File.AppendAllText(questionSystem.fileName, questionSystem.DaWholeText);








