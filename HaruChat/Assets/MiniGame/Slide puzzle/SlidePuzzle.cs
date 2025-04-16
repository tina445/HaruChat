using UnityEngine;

public class SlidePuzzle : MiniGame
{
    Board board;
    int boardSize;

    void Awake()
    {
        Debug.Log("initalize board...");
    }

    public bool CheckComplete()
    {
        Debug.Log("Do something...");
        return true; // game complete
    }

    public override void SelectLevel()
    {
        Debug.Log("setting board size...");
    }

    public override void StartGame()
    {
        Debug.Log("slide puzzle start");
    }

    public override bool EndGame()
    {
        return true; // complete
    }
}
