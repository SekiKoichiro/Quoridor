//弓矢発射する　Playerにアタッチする ModeMagaegmentを参照してCraftかJackか判断する
//木材消費する
using UnityEngine;
public class Lumberjack : MonoBehaviour
{
    [SerializeField]
    private ModeManagement ModeManagement;//0 Craft 1 Lumberjack　
    // Start is called before the first frame update
    public int deg;
    void Start()
    {
        //プレファブ化したオブジェクトからヒエラルキーのオブジェクトをアタッチ出来ないのでFind使用する
        ModeManagement = GameObject.Find("ModeManage").GetComponent<ModeManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        deg = (int)ModeManagement.mode;
        if (Input.GetMouseButtonDown(0) && (int)ModeManagement.mode == 1)//弓矢発射
        {
            ArrowFiring();
        }
        if (Input.GetMouseButtonDown(1) && (int)ModeManagement.mode == 1)//斧で木を切る
        {
            CutTree();
        }

    }
    //弓矢発射 処理
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
