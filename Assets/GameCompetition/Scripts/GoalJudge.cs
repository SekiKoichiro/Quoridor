//�S�[�����������肷��
//name�ɏ��߂ɓ��������v���C���[������A�قȂ閼�O�̃v���C���[�������������Ƃ��S�[���Ƃ���
//GoalDiplay���A�^�b�`����
using UnityEngine;

public class GoalJudge : MonoBehaviour
{
    private string name = null,playertag = "Player";
    [SerializeField]
    private GoalDisplay goaldisplay;
    private void OnTriggerEnter(Collider other)
    {
        if (name == null && other.gameObject.tag == playertag) { name = other.gameObject.name; }//���ߓ��������v���C���[�̖��O�擾
        else if(name !=  null && other.gameObject.tag == playertag && name == other.gameObject.name){//�S�[������
            goaldisplay.DisplayName();
        }
    }
}
