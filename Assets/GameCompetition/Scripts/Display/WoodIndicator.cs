//�؍ސ���UI�ɕ\������ CreateBlock.cs����Ăяo�����
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
        text.text = "�~" + message.ToString();
    }
}
