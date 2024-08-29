﻿namespace EventsOpgaver;

public class CustomEventArgs: EventArgs
{
    public double Balance { get; }

    public CustomEventArgs(double balance)
    {
        this.Balance = balance;  
    }
}
