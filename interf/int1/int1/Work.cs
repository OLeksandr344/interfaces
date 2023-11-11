using int1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int1
{
    internal class WorkTask : Itask
    {
        public string TypeOfWork { get; set; }


        public WorkTask(string type_work)
        {
            TypeOfWork = type_work;
        }
        public void Complete()
        {
            Console.WriteLine($"{TypeOfWork} COMPLETED");
        }

        public string GetTaskInfo()
        {
            return $"Work is {TypeOfWork}";
        }

        public void Start()
        {
            Console.WriteLine($"{TypeOfWork} START"); ;
        }

    }
}
internal class PersonalTask : Itask
{
    public string Person { get; set; }
    public WorkTask WorkTask { get; set; }

    public PersonalTask(WorkTask type_work, string person) 
    {
        Person = person;
        WorkTask = type_work;
    }
    public void SwapWork(PersonalTask person)
    {
        var sTypeOfWork = WorkTask;
        WorkTask = person.WorkTask;
        person.WorkTask = sTypeOfWork;
    }

    public void Complete()
    {
        Console.WriteLine($"{Person} COMPLETED {WorkTask}");
    }

    public string GetTaskInfo()
    {
        return $"Work {WorkTask} is given to {Person}";
    }

    public void Start()
    {
        Console.WriteLine($"{Person} START"); ;
    }
}

