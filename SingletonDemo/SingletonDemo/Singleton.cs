using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    /// <summary>
    /// Unachieved Singleton
    /// </summary>
    /// <param name="message"></param>
    /// 

    //class Singleton
    //{
    //    private static int counter = 0;
    //    public Singleton()
    //    {
    //        counter++;
    //        Console.WriteLine("Counter value : " + counter.ToString());
    //    }
    //    public void PrintDetails(string message) { Console.WriteLine(message); }
    //}

    /// <summary>
    /// Achieved Singleton
    /// </summary>
    /// <param name="message"></param>
    /// 

    /*
     * Sealed restricts inheritance
     */
    public sealed class Singleton
    {
        private static int counter = 0;
        /*
         * Achieved by non-Eager pattern
         */
        //private static readonly object obj = new object();

        /*
         * Private Constructor ensures that the object is not
         * instantiated other than with in the class itself
         */
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value : " + counter.ToString());
        }
        /*
         * Achieved by non-Eager pattern
         */
        //private static Singleton instance = null;

        /*
         * Achieved by Eager pattern
         */
        //private static readonly Singleton instance = new Singleton();

        /*
         * Using Lazy Keyword
         */
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Singleton GetSingletonInstance
        {
            get
            {
                /// <summary>
                /// Achieved Singleton using single thread
                /// </summary>

                //if (instance == null)
                //    instance = new Singleton();
                //return instance;

                /*
                 * lock ensures that only one thread which arrives earlier succeeds to 
                 * enter the code block and the other threads will wait till the 
                 * first thread is sompleted
                 */

                /// <summary>
                /// Achieved Singleton using multiple threads
                /// </summary>
                /// 

                /*
                 * Double verification of null checking of an instance is called Double-Checked Locking
                 * Achieved by non-Eager pattern
                 */
                //if(instance == null)
                //{
                //    lock (obj)
                //    {
                //        if (instance == null)
                //            instance = new Singleton();
                //    }
                //}

                //Achieved by Eager Loading
                //return instance;

                //Achieved by Lazy Loading
                return instance.Value;
            }
        }

        public void PrintDetails(string message) { Console.WriteLine(message); }
    }
}
