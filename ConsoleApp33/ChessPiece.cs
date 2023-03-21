using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    public abstract class ChessPiece
    {
        private string _name;
        private int _value;
        private string _symbol;

        public ChessPiece(string name, int value, string symbol)
        {
            _name = name;
            _value = value;
            _symbol = symbol;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetValue()
        {
            return _value;
        }

        public string GetSymbol()
        {
            return _symbol;
        }

        public string GetInformation()
        {
            return $"Name: {_name}\nValue: {_value}\nSymbol: {_symbol}\n";
        }
    }

    public class Pawn : ChessPiece
    {
        public Pawn() : base("Pawn", 1, "♙")
        {
        }
    }

    public class Knight : ChessPiece
    {
        public Knight() : base("Knight", 3, "♘")
        {
        }
    }

    public class Bishop : ChessPiece
    {
        public Bishop() : base("Bishop", 3, "♗")
        {
        }
    }

    public class Rook : ChessPiece
    {
        public Rook() : base("Rook", 5, "♖")
        {
        }
    }

    public class Queen : ChessPiece
    {
        public Queen() : base("Queen", 9, "♕")
        {
        }
    }

    public class King : ChessPiece
    {
        public King() : base("King", 1000, "♔")
        {
        }
    }
}
