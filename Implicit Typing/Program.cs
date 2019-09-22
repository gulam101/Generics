using System;

namespace Implicit_Typing
    {
        class Program
        {
        static void Main(string[] args)
        {
            //Calls to service
            var result = new Result<int, string> { Success = true, Data = 5, Date = "Test" };
            var result2 = new Result<string, bool> { Success = false, Data = "John", Date = true };

            Console.WriteLine(result.Success);
            Console.WriteLine(result.Data);
            Console.WriteLine(result.Date);


            Console.WriteLine(result2.Success);
            Console.WriteLine(result2.Data);
            Console.WriteLine(result2.Date);

        }
    }

    public class Result<T,U>
    {
        public bool Success { get; set; }
        public T Data { get; set; }

        public U Date { get; set; }
    }
    //    public class ResultInt
    //    {
    //    public bool Success { get; set; }
    //    public int data { get; set; }
    //    }

    //public class ResultString
    //{
    //    public bool Success { get; set; }
    //    public string data { get; set; }
    //}

    //public class ResultBool
    //{
    //    public bool Success { get; set; }
    //    public bool data { get; set; }
    //}


}


      
