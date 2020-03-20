﻿using static Compiler.Resources;

namespace Compiler
{
    class SymbolTableEntry : ISymbolTableEntry
    {
        public Token Token { get; set; }
        public string Lexeme { get; set; }
        public int Depth { get; set; }
        public EntryType TypeOfEntry { get; set; }

        public SymbolTableEntry(string _lexeme, Token _token, int _depth, EntryType _typeOfEntry)
        {
            Token = _token;
            Lexeme = _lexeme;
            Depth = _depth;
            TypeOfEntry = _typeOfEntry;
        }
    }
}
