using UnityEngine;
using Firebase.Firestore;
using System;

public class Notifier : MonoBehaviour
{
    FirebaseFirestore firebase;

    void Awake()
    {
        firebase = FirebaseFirestore.DefaultInstance;
    }

    public void AddNotification()
    {
        Debug.Log("add notification to firestore...");
    }

    public void RemoveNotification()
    {
        Debug.Log("remove notification from firestore...");
    }

    public FirebaseFirestore getBase()
    {
        return firebase; // encapsulation
    }
}
