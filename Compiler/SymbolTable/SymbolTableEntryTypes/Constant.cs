﻿using static Compiler.Resources;

namespace Compiler
{
    class Constant<T> : ISymbolTableEntry
    {
        public Token Token { get; set; }
        public string Lexeme { get; set; }
        public int Depth { get; set; }
        public EntryType TypeOfEntry { get; set; }
        public DataType TypeOfConst { get; set; }
        public int Offset { get; set; }
        public T Value { get; set; }

        public static implicit operator Constant<T>(SymbolTableEntry symbolTableEntry)
        {
            return new Constant<T>()
            {
                Lexeme = symbolTableEntry.Lexeme,
                Token = symbolTableEntry.Token,
                Depth = symbolTableEntry.Depth,
                TypeOfEntry = symbolTableEntry.TypeOfEntry
            };
        }
    }
}
