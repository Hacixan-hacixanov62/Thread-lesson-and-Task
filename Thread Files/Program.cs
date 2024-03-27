

//void Method1()
//{
//    //Thread.Sleep(3000);
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method1 - " + i);

//    }
//}


//void Method2()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method2 - " + i);

//    }
//}

//void Method3()
//{
//    for (int i = 0;i < 100; i++)
//    {
//        Console.WriteLine("Method3 - " + i);

//    }
//}

//void Method4()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine("Method4 - " + i);

////    }
////}

//Thread thread1 = new Thread(Method1);

//Thread thread2 = new Thread(Method2);

//thread1.Start();

//Method3();

//thread2.Start();

//Method4();

using System.Security.AccessControl;
using Thread_Files.Controller;

FileController fileController =new FileController();

//await fileController.ReadDataAsync();

//await fileController.CreateFileWithContentAsync();

//await fileController.DeleteAsync();

await fileController.WriteToNewFileAsync();