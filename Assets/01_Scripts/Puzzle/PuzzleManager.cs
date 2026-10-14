using UnityEngine;
using UnityEngine.InputSystem;

public class PuzzleManager : MonoBehaviour
{
    public int totalPieces = 3;
    public int piecesPlaced = 0;
    public bool solved = false;

    private void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            PlacePiece();
        }
    }

    public void PlacePiece()
    {
        if (solved) return;

        piecesPlaced++;
        Debug.Log("Piece placed: " + piecesPlaced + "/" + totalPieces);

        if (piecesPlaced >= totalPieces)
        {
            solved = true;
            Debug.Log("Puzzle solved");
        }
    }
}