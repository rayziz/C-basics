Console.WriteLine("Сейчас посмотрим надо ли сегодня работать. Вводи порядковый день недели");
string strValue = Console.ReadLine();
int value = int.Parse(strValue);

if (value == 1 | value == 2 | value == 3 | value == 4 | value == 5) Console.WriteLine("Соболезную и удачи на работе");
if (value == 6 || value == 7) Console.WriteLine("Поздравляю, Пина колада на столе");
if (value > 7) Console.WriteLine("В неделе семь дней, ещё раз так ошибёшься и на работу пойдёшь");