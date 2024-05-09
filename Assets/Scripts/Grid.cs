using UnityEngine;
using CodeMonkey.Utils;

public class Grid
{
    private int width;
    private int height;
    private float cellSize;
    private int[,] gridArray;
    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];

        Debug.Log(width + " x " + height);

        // iterate over multidimentional array
        for (int i = 0; i < gridArray.GetLength(0); i++)
        {
            for (int j = 0; j < gridArray.GetLength(1); j++)
            {
                Debug.Log(i + " - " + j);
                UtilsClass.CreateWorldText(gridArray[i, j].ToString(), null, GetWorldPosition(i, j) + new Vector3(cellSize, cellSize) * 0.5f, 20, Color.white, TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i + 1, j), Color.white, 100f);
            }
        }
        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
        Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);
    }

    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
    }
}
