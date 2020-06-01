using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_danielmcgee
{
            class Program
            {
                        static void Main(string[] args)
                        {
                                    Deck d = new Deck();
                                    Hand h = new Hand(d,2);
                                    Console.WriteLine("Created a hand of 2 cards, lets see them. \n");
                                    Console.WriteLine(h.ToString());
                                    Console.WriteLine("Let's get rid of one card from the last one drawn. \n");
                                    h.Discard(1);
                                    Console.WriteLine("Let's see the final one. \n");
                                    Console.WriteLine(h.GetCard(0).ToString());
                                    Console.WriteLine("Let's add two. \n");
                                    h.AddCard(new Card(2,2));
                                    h.AddCard(new Card(4,2));
                                    Console.WriteLine("Let's see them again. \n");
                                    Console.WriteLine(h.ToString());
                        }
            }
}
