using UnityEngine;

public class Cell : MonoBehaviour
{
    public Player owner { get; private set; } = Player.None;
    public int index = 0;

    public bool isEmpty => owner == Player.None;

    public bool Mark(Player player)
    {
        if (isEmpty)
        {
            owner = player;
            return true;
        }

        return false;
    } 
}

public enum Player { None, X, O }