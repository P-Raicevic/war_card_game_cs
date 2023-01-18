using System;
using System.Collections;
public class Player
{

    Queue p1 = new Queue();

    public Player(Queue card)
	{
        foreach(object i in card)
        {
            p1.Enqueue(i);
        }
	}

    public Player()
    {
       
    }
}
