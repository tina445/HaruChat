using UnityEngine;
using UnityEngine.UI;
using System;

public class TODOElement : MonoBehaviour
{
    public Button buttonDelete;
    public Toggle completed;
    public string TDname;
    public string docID;
    public DateTime deadline;
    public bool isCompleted;
    TDlistController listController; // parent object
    Color elementColor; 

    public void OnToggleComplete()
    {
        Debug.Log("Do something...");
    }
}
