//�؍ސ����Ǘ�����
//�J�[�\������؍ސ��ύX
using UnityEngine;

public class WoodCountManagement : MonoBehaviour
{
    [SerializeField]
    private int woodnum;
    public WoodCountManagement()
    {
        woodnum = 30;
    }

    public int WoodNum
    {
        set { woodnum = value; }
        get { return woodnum; }
    }
    //public Wood wood= new Wood();
}
