// Інтерфейс містить властивості, методи та події, реалізацію якх зобов'язуються здійснити класи-наслідники інтерфейсу.
// На C# тип може наслідувати тільки один базовий тип, але може реалізовувати безліч інтерфейсів.


using _15_Interfaces;

//Manager manager = new Manager();
//manager.Control();

//Scientist scientist  = new Scientist();
//scientist.Investigate();


//IWorker worker = new Manager();
//IWorker worker = new Scientist();
//IWorker worker = new Teacher();
//worker.Work();
//worker.Relax();


//void DoWork(IWorker worker)
//{
//    worker.Work();
//}


//IWorker[] workers =
//{
//    new Manager(),
//    new Scientist(),
//    new Teacher()
//};

//foreach(IWorker worker in workers)
//{
//    worker.Work();
//    worker.Relax();
//}


//Scientist scientist = new Scientist();

//if (scientist is IWorker) (scientist as IWorker).Relax();

//(scientist as IScientist).Investigate();
//((IWorker)scientist).Work();


//MyClass myClass = new MyClass();

//(myClass as Interface1).Method();
//(myClass as Interface2).Method();