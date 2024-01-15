

using ForTime;
using ForTime.Foctory;

TimerFactory timer = new TimerFactory();
var resTimer = timer.CreateTimer("Soat", 20);

NotfyTimerFactory timerFactory = new NotfyTimerFactory();
var res = timerFactory.CreatNotfyTimer(resTimer);

res.Initialize(StartTimer, SecondTimer, StopTimer);
res.NotfyRun();




static void StartTimer(string name, int second)
{
    Console.WriteLine($"Boshladi {name}, vaqtda {second} ");

}
static void SecondTimer(string name, int second)
{
    Console.WriteLine($"Boshladi {name}, Second: {second} ");

}
static void StopTimer(string name)
{
    Console.WriteLine($"Tugadi {name}");

}
