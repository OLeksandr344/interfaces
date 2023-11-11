using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interf
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
            return $"Work is {TypeOfWork}" ;
        }

        public void Start()
        {
            Console.WriteLine($"{TypeOfWork} START"); ;
        }
    }
    

    internal class PersonalTask : WorkTask , Itask
    {
        public string Person { get; set; }

        public PersonalTask(string type_work, string person) : base(type_work) 
        {
            Person = person;
            TypeOfWork = type_work;
        }
        public void SwapWork(PersonalTask person) 
        {
            var sTypeOfWork = TypeOfWork;     
            TypeOfWork = person.TypeOfWork;
            person.TypeOfWork = sTypeOfWork;
        }

        public void Complete()
        {
            Console.WriteLine($"{Person} COMPLETED {TypeOfWork}");
        }

        public string GetTaskInfo()
        {
            return $"Work {TypeOfWork} is given to {Person}";
        }

        public void Start()
        {
            Console.WriteLine($"{Person} START"); ;
        }
    }
}
