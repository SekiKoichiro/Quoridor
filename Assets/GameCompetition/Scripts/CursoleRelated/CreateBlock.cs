//�u���b�N�𐶐�����
//�}�E�X�̈ʒu�擾
//�K�C�h�̈ʒu�ύX
//�K�C�h��Block�ɐG��Ă��邩����
using System;
using Photon.Pun;
using UnityEngine;

public class CreateBlock : MonoBehaviourPunCallbacks
{
    public Vector3 BlockPosition;

    [SerializeField]
    private GameObject Guide,TateIs,YokoIs;
    [SerializeField]
    WoodCountManagement Wood;
    [SerializeField]
    ModeManagement ModeManagement;
    [SerializeField]
    private Transform parent;
    [SerializeField]
    private WoodIndicator WoodIndicator;
    // Update is called once per frame
    void Update()
    {
        //�J�[�\�����ړ�������J�[�\���ړ��𔽉f����
        if (BlockPosition.x != Mathf.Round(transform.position.x) || BlockPosition.z != Mathf.Round(transform.position.z)){ CheckRepositioned(); }
        
        //���N���b�N���ɉE������Block�𐶐����� �����́@���N���b�N�� ���� �����ꏊ��Block�Ȃ��� ���� ���[�h��Craft�̎�
        if (Input.GetMouseButtonDown(0) && YokoIs.GetComponent<BlockEstablishmentPossibilityJudgment>().YokoIs && (int)ModeManagement.mode == 0)
        {
            InstanceBlock("yoko");
        }
        //�E�N���b�N���ɏc������Block�𐶐����� �����́@�E�N���b�N�� ���� �����ꏊ��Block�Ȃ��� ���� ���[�h��Craft�̎�
        if (Input.GetMouseButtonDown(1) && TateIs.GetComponent<BlockEstablishmentPossibilityJudgment>().TateIs && (int)ModeManagement.mode == 0)
        {
            InstanceBlock("tate");
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
    /// <summary>
    /// Block���쐬����
    /// �������{�^���ɂ����Block�̌����ς���
    /// </summary>
    /// <param name="TateYoko"></param>
    private void InstanceBlock(string TateYoko)
    {
        //��������Block���� ���ނ̐���10�ȏ゠��Ȃ�
        if (TateYoko == "yoko" && Wood.WoodNum >= 10)
        {
            //GameObject obj = Instantiate(Block, BlockPosition, Quaternion.identity, parent);
            GameObject obj = PhotonNetwork.Instantiate("Block", BlockPosition, Quaternion.identity);
            obj.name = "BlockA";
        }
        else if (TateYoko == "tate" && Wood.WoodNum >= 10)
        {
            //GameObject obj = Instantiate(Block, BlockPosition, Quaternion.Euler(0, 90, 0), parent);
            GameObject obj = PhotonNetwork.Instantiate("Block", BlockPosition, Quaternion.Euler(0, 90, 0));
            obj.name = "BlockB";
        }
        else
        {
            Console.Write("�N���b�N���e�����݂��܂���");
            return ;
        }

        Wood.WoodNum -= 10;//�؍ތ��炷
        WoodIndicator.SetNum(Wood.WoodNum);//UI�̖؍ނ̕\����ύX����
    }

}
