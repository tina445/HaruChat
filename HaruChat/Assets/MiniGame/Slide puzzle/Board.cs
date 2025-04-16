using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Board : MonoBehaviour, IDropHandler
{
    int size;
    public Tile[][] elements;
    public GameObject visualBoard;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Do something...");
    }

    void CreateSlots()
    {
        Debug.Log("create board...");
    }
}
