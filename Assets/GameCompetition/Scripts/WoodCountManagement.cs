//木材数を管理する
//カーソルから木材数変更
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
