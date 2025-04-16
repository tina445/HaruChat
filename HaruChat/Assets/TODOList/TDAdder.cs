using UnityEngine;
using UnityEngine.UI;
using System;

public class TDAdder : MonoBehaviour
{
    public Dropdown Dyear, Dmonth, Dday, Dhour, Dminute;
    public InputField inputName;
    public DateTime deadline;
    public string TDname;
    public Button confirm;

    public DateTime SelectDeadline()
    {
        Debug.Log("Do something...");
        return deadline; // tmp
    }

    public void SetName()
    {
        Debug.Log("Do something...");
    }

    public void FinishJob()
    {
        Debug.Log("Do sonething...");
    }
}
