//Craft Block作成　Lumberjack 木を切る　弓矢発射
//モードの管理はプレイヤーのブロック作成(CreateBlock.cs)と木こり(Lumberjack.cs)から参照させる
using UnityEngine;

public class ModeManagement : MonoBehaviour
{
    [SerializeField]
    private ModeDisplay ModeDisplay;

    public enum Mode { Craft, Jack }
    public Mode mode = Mode.Craft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y > 0) {
            mode = Mode.Craft;
            ModeDisplay.SetMode(mode);
        }
        if (Input.mouseScrollDelta.y < 0) {
            mode = Mode.Jack;
            ModeDisplay.SetMode(mode);
        }

    }
}
