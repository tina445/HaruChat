using UnityEngine;
using UnityEngine.UI;

public abstract class MiniGame : MonoBehaviour
{
    protected int level;
    protected float playTime; // deltaTime
    protected bool isPlaying;

    public abstract void SelectLevel();
    public abstract void StartGame();
    public abstract bool EndGame();
}
