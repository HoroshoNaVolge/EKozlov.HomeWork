using static MyLibrary.MyMethods;
using static MyLibrary.Message;

TaskCreator creator = new TaskCreator();
bool isFirstExecution = true;

while (creator.AskToStart(isFirstExecution))
{
    HomeworkTask currentTask = creator.CreateTask(GetConsoleInput(invite_to_input_hometask_number_msg));
    ShowMessage(currentTask.Execute());
    isFirstExecution = false;
}