using UnityEngine;

public enum TileType
{
    Empty,
    Wall,
    Goal,
}

public class Board : MonoBehaviour
{
    public TileType[,] Tiles;
    public int Size { get; set; }

    public int DestX { get; set; }
    public int DestY { get; set; }

    private Material EmptyMat;
    private Material WallMat;
    private Material GoalMat;

    public void Initialze()
    {
        DestY = Size - 2;
        DestX = Size - 2;

        EmptyMat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        EmptyMat.color = Color.gray;
        
        WallMat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        WallMat.color = Color.white;

        GoalMat = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        GoalMat.color = Color.green;

        Tiles = new TileType[Size, Size];
        Size = Size;

        GeneratebySiedeWinder();

        Camera.main.transform.position = new Vector3(Size/2, Size, -Size/2);
        Camera.main.transform.rotation = Quaternion.Euler(90, 0, 0);
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private void GeneratebySiedeWinder()
    {
        for (int y = 0; y < Size; y++)
        {
            for (int x = 0; x < Size; x++)
            {
                if (x % 2 == 0 || y % 2 == 0)
                {
                    Tiles[x, y] = TileType.Wall;
                }
                else if ( x == DestX && y == DestY)
                {
                    Tiles[x, y] = TileType.Goal;
                }
                else
                {
                    Tiles[x, y] = TileType.Empty;
                }
            }
        }

        for (int y = 0; y < Size; y++)
        {
            int count = 0;
            for (int x = 0; x < Size; x++)
            {
                if ( x % 2 == 0 || y % 2 == 0) continue;
                if ( y == Size - 2 && x == Size - 2) continue;
                if (y == Size - 2)
                {
                    Tiles[y, x + 1] = TileType.Empty;
                    continue;
                }
                if (x == Size - 2)
                {
                    Tiles[y + 1, x] = TileType.Empty;
                    continue;
                }
                if (Random.Range(0, 2) == 0)
                {
                    Tiles[y, x + 1] = TileType.Empty;
                    count++;
                }
                else
                {
                    Tiles[y + 1, x - Random.Range(0, count) * 2] = TileType.Empty;
                    count = 1;
                }
            }
        }
    }

    public void Spawn()
    {
        for (int y = 0; y < Size; y++)
        {
            for (int x = 0; x < Size; x++)
            {
                GameObject Go = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Go.transform.position = new Vector3(x, 0, -y);
                Go.transform.parent = transform;

                if (Tiles[y, x] == TileType.Empty || Tiles[y, x] == TileType.Goal)
                {
                    Go.transform.localScale = new Vector3(1f, 0.1f, 1f);
                }
                else
                {
                    Go.transform.localScale = new Vector3(1f, 2f, 1f);
                }
                Go.GetComponent<MeshRenderer>().sharedMaterial = GetTileColor(Tiles[y, x]);
            }
        }
    }

    private Material GetTileColor(TileType type)
    {
        return type switch
        {
            TileType.Empty => EmptyMat,
            TileType.Wall => WallMat,
            TileType.Goal => GoalMat,
            _ => EmptyMat,
        };
    }
}