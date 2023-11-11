using int1;

WorkTask t1 = new WorkTask("cleaning");
WorkTask t2 = new WorkTask("coding");
PersonalTask p1 = new PersonalTask(t1, "John");
PersonalTask p2 = new PersonalTask(t2, "Jonny");
void ShowInfo(PersonalTask p)
{
    Console.WriteLine($"{p.WorkTask.TypeOfWork}");

}
ShowInfo(p1);
p1.SwapWork(p2);
ShowInfo(p1);