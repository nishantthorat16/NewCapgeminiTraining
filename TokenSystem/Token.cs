﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenSystem
{
    public class Token : IEquatable<Token>
    {
        public string Name       { get; set; }
        public string Email      { get; set; }
        public uint TokenNumer   
                { get; private set; }

        private static uint tokenCounter = 1;
        public Token()
        {
            TokenNumer = tokenCounter ++;
        }

        public bool Equals(Token other)
        {
            return Email.Equals(other.Email
             , StringComparison.OrdinalIgnoreCase);
        }
    }
}
