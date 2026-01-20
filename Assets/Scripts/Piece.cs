using System.Collections;
using UnityEngine;

public abstract class Piece 
{
    public enum PieceType
    {
        pawn,
        knight,
        bishop,
        rook,
        queen,
        king
    }

    public PieceType type;
    public bool sideIsWhite;
    private Board board;

    public abstract bool MovePiece(int x, int y);

    public bool BecomeCaptured() 
    {
        return true;
    }

    public bool CapturePiece() 
    {
        return true;
    }



    public Board GetBoard() 
    { 
        return board;
    }



}
