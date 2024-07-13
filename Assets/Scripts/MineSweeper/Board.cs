using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    public Tilemap Tilemap {  get; private set; }
    public Tile tileEmpty;
    public Tile tileMine;
    public Tile tileFlag;
    public Tile tileUnknown;
    public Tile tileNum1, tileNum2, tileNum3, tileNum4, tileNum5, tileNum6;
    private void Awake()
    {
        Tilemap = GetComponent<Tilemap>();
    }

    public void Draw(Cells[,] state)
    {
        int width = state.GetLength(0);
        int height = state.GetLength(1);

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Cells cell = state[i, j];
                Tilemap.SetTile(cell.position, GetTile(cell));
            }
        }
    }

    private Tile GetTile(Cells cell)
    {
        if (cell.revealed)
        {
            return GetRevealedTile(cell);
        }
        else if (cell.flagged)
        {
            return tileFlag;
        }
        else 
        {
            return tileUnknown;
        }
    }

    private Tile GetRevealedTile(Cells cell)
    {
        switch (cell.type)
        {
            case Cells.Type.Empty: return tileEmpty;
            case Cells.Type.Mine: return tileMine;
            case Cells.Type.Number: return GetTileNumber(cell);
            default: return null;
        }
    }

    private Tile GetTileNumber(Cells cell)
    {
        switch (cell.number)
        {
            case 1: return tileNum1;
            case 2: return tileNum2;
            case 3: return tileNum3;
            case 4: return tileNum4;
            case 5: return tileNum5;
            case 6: return tileNum6;
            default: return null;
        }
    }
}
