using UnityEngine;

public class Haru : Character, ITalking
{
    protected override void Awake()
    {
        Debug.Log("Initalize Character model...");

        characterName = "Haru";
        gptModel = "something Fine-tuned model";
        ttsModel = "TBD";
    }

    protected override void ShowExpression(int emotion)
    {
        Debug.Log("Play something animation...");
    }

    protected override void IdleAnim()
    {
        Debug.Log("Play Idle animation");
    }

    public int SayMassage(string massage)
    {
        Debug.Log("Call GPT model...");
        Debug.Log("Call TTS model");

        return 1; // return emotion id
    }
}
