using UnityEngine;
using UnityEngine.UI;

public class MiniGameController : MonoBehaviour
{
    public ScrollRect games; // minigame container
    public LevelSelector levelSelector;

    public void PlayGame(int gameID)
    {
        Debug.Log("minigame start");
    }
}
