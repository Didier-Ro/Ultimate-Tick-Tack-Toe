using System.Linq;
using UnityEngine;

public class SmallTable : MonoBehaviour
{
    [SerializeField] private Cell[] cells = new Cell[9];

    public Player winner = Player.None;

    public bool isActive = true;

    public bool isFull => cells.All(cell => !cell.isEmpty);

    public bool CheckWin()
    {
        return false;
    }
}
