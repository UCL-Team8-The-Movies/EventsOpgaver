namespace EventsOpgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            //Opgave 4
            Sparegris sparegris = new Sparegris();
            Subscriber subscriber = new Subscriber();
                        
            subscriber.Subscribe(sparegris);
            
            sparegris.InsertAmount(400);
            sparegris.InsertAmount(400);

        }
    }
}
