using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_danielmcgee
{
            class Hand
            {
                        private List<Card> cards;
                        private int numberOfCards;
                        public int NumCards
                        {
                                    get
                                    {
                                                return numberOfCards;
                                    }
                        }
                        public void AddCard(Card c)
                        {
                                    cards.Add(c);
                                    numberOfCards++;
                        }
                        public Card Discard(int index)
                        {
                                    Card temp = cards[index];
                                    cards.Remove(cards[index]);
                                    numberOfCards--;
                                    return temp;
                        }
                        public Card GetCard(int index)
                        {
                                    return cards[index];
                        }
                        public Hand()
                        {
                                    cards = new List<Card>();
                                    numberOfCards = 0;
                        }
                        public Hand(Deck d,int numCards)
                        {
                                    cards = new List<Card>();
                                    numberOfCards = numCards;
                                    for(int i = 0; i < numCards;i++)
                                    {
                                                cards.Add(d.Draw());
                                    }
                        }
                        public bool HasCard(Card c)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (c.Equals(cards[i]))
                                                            return true;
                                    }
                                    return false;
                        }

                        public bool HasCard(int v)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if(cards[i].Value == v)
                                                            return true;
                                    }
                                    return false;
                        }

                        public bool HasCard(int v,int s)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (cards[i].Value == v && cards[i].Suit == s)
                                                            return true;
                                    }
                                    return false;
                        }

                        public int IndexOf(Card c)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (c.Equals(cards[i]))
                                                            return i;
                                    }
                                    return -1;
                        }

                        public int IndexOf(int v)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (cards[i].Value == v)
                                                            return i;
                                    }
                                    return -1;
                        }

                        public int IndexOf(int v, int s)
                        {
                                    for (int i = 0; i < cards.Count; i++)
                                    {
                                                if (cards[i].Value == v && cards[i].Suit == s)
                                                            return i;
                                    }
                                    return -1;
                        }

                        public override string ToString()
                        {
                                    string result = "\n";
                                    for(int i = 0; i < cards.Count;i++)
                                    {
                                                result += cards[i].ToString() + "\n";
                                    }
                                    return result;
                        }
            }
}
