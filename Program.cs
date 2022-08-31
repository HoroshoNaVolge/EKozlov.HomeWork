using MyLibrary;
  
        int homeworkNumber = MyMethods.GetConsoleInput(Message.invite_to_input_hometask_number_msg); // парсим после проверки на ввод с рекурсивным вызовом ввода при некорректном вводе
        
        TaskCreator creator= new TaskCreator (); 

        HomeworkTask currentTask= creator.CreateTask(homeworkNumber);

        Console.WriteLine(currentTask.ExecuteTask());
        