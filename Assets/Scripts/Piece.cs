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
    public Board board;

    public abstract bool MovePiece(int x, int y);

}
