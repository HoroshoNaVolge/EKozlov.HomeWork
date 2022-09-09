﻿using EKozlov.HomeWork.BL;
using EKozlov.HomeWork.View;

HomeWorkManager taskManager = HomeWorkManager.getInstance(new Console_UI()); // получаем экземпляр менеджера домашних заданий. В данной реализации передаем параметром Консольный UI.

taskManager.Run(); // запускаем выполнение менеджера домашних заданий.