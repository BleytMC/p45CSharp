// Створення папки

//string path = @"Folder1\Folder2";
//Directory.CreateDirectory(path);


// Видалення папки

//string path = @"Folder1\Images";
//Directory.Delete(path, true);


// Переіменування і переміщення папки

//string pathFrom = @"Folder1\Folder2";
//string pathTo = @"Folder1\Folder100";

//Directory.Move(pathFrom, pathTo);


//string pathFrom = @"Folder1\Folder100";
//string pathTo = @"Folder1\1\Folder100";

//Directory.Move(pathFrom, pathTo);


// Перевірка чи папка існує

//string path = @"Folder1\1\Folder1020";
//if(Directory.Exists(path)) Console.WriteLine("+");
//else Console.WriteLine("-");


// Доступ до батьківсьої папки

//string path = @"Folder1\1\Folder100";
//DirectoryInfo parent = Directory.GetParent(path);

//Console.WriteLine(parent.FullName);


// Перелік логічних дисків

//string[] drives = Directory.GetLogicalDrives();

//foreach(string drive in drives) Console.WriteLine(drive);


// Перелік папок

//string path = @"Folder1";

//string[] files = Directory.GetFiles(path);

//foreach (string file in files)
//{
//    FileInfo fileInfo = new FileInfo(file);
//    Console.WriteLine(fileInfo.Name);
//}


//string path = @"Folder1";
//string[] entries = Directory.GetFileSystemEntries(path);

//foreach (string entry in entries)
//{
//    Console.WriteLine(entry);
//}


// File

//string path = @"Folder1\1\Folder100\data.bin";
//File.Create(path);


//string path = @"Folder1\1\Folder100\data1.txt";
//File.Delete(path);


//string pathFrom = @"Folder1\1\Folder100\atad.txt";
//string pathTo = @"Folder1\1\atad.txt";

//File.Copy(pathFrom, pathTo);


// DirectoryInfo

//string path = "Folder1";
//DirectoryInfo directoryInfo = new DirectoryInfo(path);

//Console.WriteLine(directoryInfo.Name);
//Console.WriteLine(directoryInfo.FullName);
//Console.WriteLine(directoryInfo.Parent.Name);
//Console.WriteLine(directoryInfo.Root.Name);
//Console.WriteLine(directoryInfo.CreationTime);


// FileInfo

//string path = "Folder1/myfile.txt";

//FileInfo fileInfo = new FileInfo(path);

////fileInfo.Create();

//Console.WriteLine(fileInfo.Length);


//void Find(string fileName, DirectoryInfo root)
//{
//    foreach(FileInfo file in root.GetFiles()) if(file.Name == fileName) Console.WriteLine(file.FullName);
//    foreach (DirectoryInfo directory in root.GetDirectories()) Find(fileName, directory);
//}

//string fileName = "data.txt";
//string directoryPath = "Folder1";
//DirectoryInfo root = new DirectoryInfo(directoryPath);

//Find(fileName, root);


void Remove(string fileName, DirectoryInfo root)
{
    foreach (FileInfo file in root.GetFiles()) if (file.Name == fileName)
    {
        Console.WriteLine($"File {file.FullName} has been removed");
        file.Delete();
    }
    foreach (DirectoryInfo directory in root.GetDirectories()) Remove(fileName, directory);
}

string fileName, directoryPath;

fileName = Console.ReadLine();
directoryPath = Console.ReadLine();
DirectoryInfo directory = new DirectoryInfo(directoryPath);
Remove(fileName, directory);