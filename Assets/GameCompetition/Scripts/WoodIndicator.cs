//ñÿçﬁêîÇUIÇ…ï\é¶Ç∑ÇÈ
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WoodIndicator : MonoBehaviour
{
    [SerializeField]
    private WoodCountManagement Wood;
    private TextMeshProUGUI text;
    void Start()
    {
        text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }
    public void SetNum(int message)
    {
        text.text = message.ToString();
    }
}
