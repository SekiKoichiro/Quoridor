//�u���b�N�𐶐�����
//�}�E�X�̈ʒu�擾
//�K�C�h�̈ʒu�ύX
//�K�C�h��Block�ɐG��Ă��邩����
using UnityEngine;

public class CreateBlock : MonoBehaviour
{
    public Vector3 BlockPosition;

    [SerializeField]
    private GameObject Block,Guide,TateIs,YokoIs;
    [SerializeField]
    WoodCountManagement Wood;
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private WoodIndicator WoodIndicator;
    // Update is called once per frame
    void Update()
    {
        //�J�[�\�����ړ�������J�[�\���ړ��𔽉f����
        if (BlockPosition.x != Mathf.Round(transform.position.x) || BlockPosition.z != Mathf.Round(transform.position.z)){ CheckRepositioned(); }
        
        //���N���b�N���ɉE������Block�𐶐�����
        if (Input.GetMouseButtonDown(0) && YokoIs.GetComponent<BlockEstablishmentPossibilityJudgment>().YokoIs)
        {
            InstanceBlockYoko();
        }
        //���N���b�N���ɏc������Block�𐶐�����
        if (Input.GetMouseButtonDown(1) && TateIs.GetComponent<BlockEstablishmentPossibilityJudgment>().TateIs)
        {
            InstanceBlockTate();
        }
    }
    //�K�C�h�̈ʒu���ύX���ꂽ�ꍇ�K�C�h�ʒu�X�V
    public void CheckRepositioned()
    {
        BlockPosition.x = Mathf.Round(transform.position.x);
        BlockPosition.y = 0;
        BlockPosition.z = Mathf.Round(transform.position.z);
        //�K�C�h�̈ʒu�ύX
        Guide.GetComponent<GuidePositionSetting>().SetGuidePosition(BlockPosition);
    }
    //Block�쐬
    private void InstanceBlockYoko()
    {
        //�v���p�e�B�̎g���������Ă��邩?
        if ( Wood.WoodNum >= 10)
        {
            GameObject obj = Instantiate(Block, BlockPosition, Quaternion.identity, parent);
            obj.name = "BlockA";
            Wood.WoodNum -= 10;//�؍ތ��炷
            WoodIndicator.SetNum(Wood.WoodNum);//UI�̖؍ނ̕\����ύX����
        }

    }

    private void InstanceBlockTate()
    {
        //�v���p�e�B�̎g���������Ă��邩?
        if (Wood.WoodNum >= 10)
        {
            GameObject obj = Instantiate(Block, BlockPosition, Quaternion.Euler(0, 90, 0), parent);
            obj.name = "BlockA";
            Wood.WoodNum -= 10;
            WoodIndicator.SetNum(Wood.WoodNum);//UI�̖؍ނ̕\����ύX����
        }
    }

}
