using System;
using System.Collections;
using System.Windows.Forms;
using WindowDemo1;

public class Game
{
	public Game()
	{

	}

    Queue p1 = new Queue();
    Queue p2 = new Queue();
    Queue pomoc = new Queue();

    public static void RatR(Queue spil1, Queue spil2, Queue pomoc)
    {

        if(spil1.Count==0 && spil2.Count!=0)
        {
            String s = "";
            MessageBox.Show("Drugi igrac pobjedjuje");
            spil2.Clear();
            return;
        }
        else if (spil1.Count != 0 && spil2.Count == 0)
        {
            String s = "";
            MessageBox.Show("Prvi igrac pobjedjuje");
            spil1.Clear();
            return;
        }


        Card k1 = (Card)spil1.Dequeue();
        Card k2 = (Card)spil2.Dequeue();

        if (Int32.Parse(k1.face) > Int32.Parse(k2.face))
        {
            foreach (object obj in pomoc)
            {
                spil1.Enqueue(obj);
            }
            spil1.Enqueue(k1);
            spil1.Enqueue(k2);
            pomoc.Clear();
            return;
        }
        else if (Int32.Parse(k1.face) < Int32.Parse(k2.face))
        {
            foreach (object obj in pomoc)
            {
                spil2.Enqueue(obj);
            }
            spil2.Enqueue(k2);
            spil2.Enqueue(k1);
            pomoc.Clear();
            return;
        }

        else if (Int32.Parse(k1.face) == Int32.Parse(k2.face))
        {
            if (spil1.Count == 0)
            {
                foreach (object obj in pomoc)
                {
                    spil1.Enqueue(obj);
                }
                spil2.Enqueue(k1);
                spil2.Enqueue(k2);
                MessageBox.Show("Drugi igrac pobjedjuje");
                pomoc.Clear();
                return;

            }
            else if (spil2.Count == 0)
            {
                foreach (object obj in pomoc)
                {
                    spil1.Enqueue(obj);
                }
                spil1.Enqueue(k1);
                spil1.Enqueue(k2);
                MessageBox.Show("Prvi igrac pobjedjuje");
                pomoc.Clear();
                return;
            }
            else if (spil1.Count == 0 && spil2.Count == 0)
            {
                MessageBox.Show("Its a Draw!", "Draw");
                return;
            }
            pomoc.Enqueue(k1);
            pomoc.Enqueue(k2);
            return; 
        }
    }

    public static void deal(Queue spil1, Queue spil2)
    { 
        Deck deck1 = new Deck();
        deck1.Shuffle();

         for (int i = 0; i < 52; i++)
         {
             if (i % 2 == 0)
             {
                 spil1.Enqueue(deck1.DealCard());
             }
             else
             {
                spil2.Enqueue(deck1.DealCard());
             }
         }
    }

    public static void deal2(Queue spil1, Queue spil2)
    {
        Deck deck1 = new Deck();
        deck1.Shuffle2();
        
        for (int i = 0; i < 52; i++)
        {
            if (i<26)
            {
                spil1.Enqueue(deck1.DealCard());
            }
            else
            {
                spil2.Enqueue(deck1.DealCard());
            }
        }
    }

    public static void deal3(Queue spil1, Queue spil2)
    {
        Deck deck1 = new Deck();
        deck1.Shuffle3();

        for (int i = 0; i < 52; i++)
        {
            if (i < 26)
            {
                spil1.Enqueue(deck1.DealCard());
            }
            else
            {
                spil2.Enqueue(deck1.DealCard());
            }
        }
    }

    public void start(Queue p1, Queue p2, Queue pomoc)
    {
        p1.Clear();
        p2.Clear();
        pomoc.Clear();
        deal(p1, p2);
    }

    public void start2(Queue p1, Queue p2, Queue pomoc)
    {
        p1.Clear();
        p2.Clear();
        pomoc.Clear();
        deal2(p1, p2);
    }

    public void start3(Queue p1, Queue p2, Queue pomoc)
    {
        p1.Clear();
        p2.Clear();
        pomoc.Clear();
        deal3(p1, p2);
    }

    public void igraj(Queue p1, Queue p2)
    {
        RatR(p1, p2, pomoc);
    }

}
