using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        /// <summary>
        /// Unachieved Singleton using single thread
        /// </summary>
        /// <param name="message"></param>
        /// 

        //static void Main(string[] args)
        //{
        //    Singleton fromEmployee = new Singleton();
        //    fromEmployee.PrintDetails("From Employee!!..");
        //    Singleton fromStudent = new Singleton();
        //    fromStudent.PrintDetails("From Student!!...");

        //    Console.ReadLine();
        //}

        /// <summary>
        /// Achieved Singleton using single thread
        /// </summary>
        /// <param name="message"></param>
        /// 
        //static void Main(string[] args)
        //{
        //    Singleton fromEmployee = Singleton.GetSingletonInstance;
        //    fromEmployee.PrintDetails("From Employee!!..");

        //    Singleton fromStudent = Singleton.GetSingletonInstance;
        //    fromStudent.PrintDetails("From Student!!...");

        //    Console.ReadLine();
        //}

        /// <summary>
        /// Achieved Singleton using multiple threads
        /// </summary>
        /// <param name="message"></param>
        /// 
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintEmployeeDetails(),
                () => PrintStudentDetails()
                );

            Console.ReadLine();
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.GetSingletonInstance;
            fromStudent.PrintDetails("From Student!!...");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.GetSingletonInstance;
            fromEmployee.PrintDetails("From Employee!!..");
        }
    }
}
