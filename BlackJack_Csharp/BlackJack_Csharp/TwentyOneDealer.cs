﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack_Csharp
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public bool Stay { get; set; }
        public bool IsBusted { get; set; }
    }
}
