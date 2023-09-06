using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public abstract class BaseModel
    {
        public int id;
        static int counter;

        public int Id { get; private set; }
        //static int Counter { get;  set; }

        public BaseModel()
        {
            this.id = counter;
            counter++;
        }

        static BaseModel()
        {
            Random Rand = new Random();
            counter = Rand.Next();
        }
       // protected BaseModel()
        //{
        //   Id = counter;
        //}


    }
    
}
