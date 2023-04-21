//åªç›ÇÃÉÇÅ[Éh(Craft ,Lumberjac)Çï\é¶Ç∑ÇÈ
using UnityEngine;
using TMPro;

public class ModeDisplay : MonoBehaviour
{
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void SetMode(ModeManagement.Mode mode)
    {
        text.text = "" + mode.ToString();
        return;
    }
}
