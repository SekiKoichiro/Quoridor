//�|��˂���@Player�ɃA�^�b�`���� ModeMagaegment���Q�Ƃ���Craft��Jack�����f����
//�؍ޏ����
using UnityEngine;
public class Lumberjack : MonoBehaviour
{
    [SerializeField]
    private ModeManagement ModeManagement;//0 Craft 1 Lumberjack�@
    // Start is called before the first frame update
    public int deg;
    void Start()
    {
        //�v���t�@�u�������I�u�W�F�N�g����q�G�����L�[�̃I�u�W�F�N�g���A�^�b�`�o���Ȃ��̂�Find�g�p����
        ModeManagement = GameObject.Find("ModeManage").GetComponent<ModeManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        deg = (int)ModeManagement.mode;
        if (Input.GetMouseButtonDown(0) && (int)ModeManagement.mode == 1)//�|���
        {
            ArrowFiring();
        }
        if (Input.GetMouseButtonDown(1) && (int)ModeManagement.mode == 1)//���Ŗ؂�؂�
        {
            CutTree();
        }

    }
    //�|��� ����
    private void ArrowFiring() {
        /*
        GameObject obj = PhotonNetwork.Instantiate("Block", BlockPosition, Quaternion.identity);
        obj.name = "BlockA";
        */

        Debug.Log("yumi");
        return;
    }
    private void CutTree() {
        Debug.Log("CUT");
        return;
    }



}
