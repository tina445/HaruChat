using UnityEngine;
using Live2D.Cubism.Core;

public abstract class Character : MonoBehaviour
{
    public string characterName;
    protected string gptModel;
    protected string ttsModel;
    protected CubismModel live2DModel;

    protected abstract void Awake();
    protected abstract void ShowExpression(int emotion);
    protected abstract void IdleAnim();
}
