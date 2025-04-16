using UnityEngine;
using Firebase.Messaging;

public class UserController : MonoBehaviour, ITalking
{
    string fcmToken;
    public static UserController Instance; // singleton instance

    void Awake()
    {
        if (Instance == null) Instance = this; // singleton
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        // receive fcm token event
    }

    public int getPoint()
    {
        // get user points
        return 100;
    }

    public void setPoint(int value)
    {
        // user.point += value
    }

    public int SayMassage(string massage)
    {
        return 100; // return cost
    }

    void OnTokenReceived(object sender, TokenReceivedEventArgs token)
    {
        Debug.Log("do something...");
    }

    public string getToken()
    {
        return fcmToken; // encapsulation
    }

    public static UserController getInstance()
    {
        return Instance; // singleton
    }
}
