//木材数をUIに表示する CreateBlock.csから呼び出される
using UnityEngine;
using TMPro;
public class WoodIndicator : MonoBehaviour
{
    private TextMeshProUGUI text;
    void Start()
    {
        text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }
    public void SetNum(int message)
    {
        text.text = "×" + message.ToString();
    }
}
