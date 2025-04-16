using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public int id;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Do something...");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Do something...");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Do something...");
    }
}
