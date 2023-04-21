//Craft Block�쐬�@Lumberjack �؂�؂�@�|���
//���[�h�̊Ǘ��̓v���C���[�̃u���b�N�쐬(CreateBlock.cs)�Ɩ؂���(Lumberjack.cs)����Q�Ƃ�����
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
