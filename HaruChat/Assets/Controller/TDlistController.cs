using UnityEngine;
using UnityEngine.UI;

public class TDlistController : MonoBehaviour
{
    public TDAdder elementAdder;
    public ScrollRect TDlist; // TODOElement container
    public Notifier notifier;

    public void DeleteTD()
    {
        // Delete something...
        // remove notification...
    }

    public void AddTD()
    {
        Debug.Log("Do something...");
        Debug.Log("add notification...");
    }

    public void OnEnable()
    {
        Debug.Log("Do something...");
    }

    public void OnTDcompleteToggle(string docID, bool isCompleted)
    {
        Debug.Log("Do something...");
    }
}
