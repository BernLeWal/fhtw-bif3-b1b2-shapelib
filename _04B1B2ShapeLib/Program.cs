namespace _04B1B2ShapeLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User user1 = new User(1, "Susi Sorglos", "susi@company.com", "1234");
            User user2 = new User(2, "Peter Lustig", "peter@lustig.at", "4321");
            Console.WriteLine( user1 );

            var myObject = new Program();
            myObject.MyActionMethod(1);    // call the method directly, the classical approach

            // **** DELEGATES: ****
            Action<int> myAction = myObject.MyActionMethod;     // create a delegate
            myAction(2);                                        // call the delegate

            myObject.LongLastingCalulation(3, myAction);        // use delegate as parameter
            myObject.LongLastingCalulation(4, (i) => { Console.WriteLine($"Lambda Callback {i} may also use {myObject}"); } );

            // **** EVENTS: ****
            // define an event handler
            myObject.MyEvent += user1.EventHandler;
            myObject.MyEvent += user2.EventHandler;
            myObject.LongLastingCalulation(5);
            myObject.MyEvent -= user1.EventHandler;
            myObject.LongLastingCalulation(6);

        }

        public void MyActionMethod(int i)
        {
            Console.WriteLine($"MyActionMethod: {i}");
        }

        public void LongLastingCalulation(int i, Action<int> callback)
        {            
            Thread.Sleep(3000); // do some long lasting calculation
            callback(i);
        }


        // ***** EVENT-HANDLING *****
        public event EventHandler? MyEvent;
        public void LongLastingCalulation(int i)
        {
            // do some long lasting calculation
            Thread.Sleep(3000);

            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}