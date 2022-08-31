using MyLibrary;
  
        int homeworkNumber = MyMethods.GetConsoleInput(Message.invite_to_input_hometask_number_msg); // парсим после проверки на ввод с рекурсивным вызовом ввода при некорректном вводе
        
        HomeworkTask currentTask= new HomeworkTask(homeworkNumber); // переменная класса домашнего задания. Логика выполнение программы зависит от полученного номера ДЗ.
        currentTask.Run();