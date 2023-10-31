
DateTime datNow = new DateTime();
DateTime datMiddle = new DateTime(2023, 01, 01);
datNow = DateTime.Now;
string info;
int daysCount = Convert.ToInt32((datNow - datMiddle).TotalDays);
for (int i = 0; i <= 365; ++i)
{
    if (i == daysCount)
    {
        if (daysCount > 99)
        {
            Console.WriteLine(daysCount+1 + " " + "день накопления");
            info = Convert.ToString(daysCount+1);
            info = info.Insert(1, ".");
            Console.WriteLine(info + " " + "руб");
        }
        else
        {
            Console.WriteLine(daysCount+1 + " " + "день накопления");
            Console.WriteLine(daysCount+1 + " " + "копеек");
        }

    }
}
bool Exit = false;
while (!Exit)
{
    Exit = Console.ReadLine() == "exit";
}

