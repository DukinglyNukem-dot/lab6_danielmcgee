using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_danielmcgee
{
            class BJHand : Hand
            {
                        public BJHand() : base()
                        {

                        }
                        public BJHand(Deck d, int numCards) : base(d, numCards)
                        {
                                    
                        }
                        public bool HasAce
                        {
                                    get
                                    {
                                                return HasCard(0);
                                    }
                        }
                        public int Score
                        {
                                    get
                                    {
                                                int addition = 0;
                                                for(int i = 0; i < NumCards; i++)
                                                {

                                                }
                                                return addition;
                                    }
                        }
            }
}
