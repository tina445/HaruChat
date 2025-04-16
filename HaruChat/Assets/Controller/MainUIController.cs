using UnityEngine;
using UnityEngine.UI;

public class MainUIController : MonoBehaviour
{
    public TDlistController TDlist;
    public MiniGameController GameList;
    public Button buttonTDlist;
    public Button buttonGameList;
    public InputField textMessageInput;
    public Button audioMessageInput;

    public void ShowTDlist()
    {
        TDlist.gameObject.SetActive(true);
    }

    public void ShowGameList()
    {
        GameList.gameObject.SetActive(true);
    }

    public string getMessage()
    {
        return "안뇽";
    }
}
