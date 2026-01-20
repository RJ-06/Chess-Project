using UnityEngine;

public class Board
{
    private Piece[][] boardPositions;

    public bool IsValidPosition(int x, int y) 
    {
        if (x < 0 || 
            y < 0 ||
            x > boardPositions.Length ||
            y > boardPositions[0].Length) 
        {
            return false;
        }
        return true;
    }

    public bool RemovePieceFromPosition(Piece p, int x, int y) 
    {
        if(!IsValidPosition(x, y))
        {
            return false;
        }
        if (p == null || boardPositions[x][y] != p) 
        {
            return false;
        }
        boardPositions[x][y] = null;
        return true;
    }

    public bool MovePieceToPosition(Piece p, int x, int y) 
    {
        if (!IsValidPosition(x, y))
        {
            return false;
        }
        if (p == null || boardPositions[x][y] != null)
        {
            return false;
        }
        boardPositions[x][y] = p;
        return true;
    }

}
