//ブロックを生成する
//マウスの位置取得
//ガイドの位置変更
//ガイドがBlockに触れているか判定
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
        //カーソルが移動したらカーソル移動を反映する
        if (BlockPosition.x != Mathf.Round(transform.position.x) || BlockPosition.z != Mathf.Round(transform.position.z)){ CheckRepositioned(); }
        
        //左クリック時に右向きにBlockを生成する 条件は　左クリック時 かつ 生成場所にBlockない時 かつ モードがCraftの時
        if (Input.GetMouseButtonDown(0) && YokoIs.GetComponent<BlockEstablishmentPossibilityJudgment>().YokoIs && (int)ModeManagement.mode == 0)
        {
            InstanceBlock("yoko");
        }
        //右クリック時に縦向きにBlockを生成する 条件は　右クリック時 かつ 生成場所にBlockない時 かつ モードがCraftの時
        if (Input.GetMouseButtonDown(1) && TateIs.GetComponent<BlockEstablishmentPossibilityJudgment>().TateIs && (int)ModeManagement.mode == 0)
        {
            InstanceBlock("tate");
        }
    }
    //ガイドの位置が変更された場合ガイド位置更新
    public void CheckRepositioned()
    {
        BlockPosition.x = Mathf.Round(transform.position.x);
        BlockPosition.y = 0;
        BlockPosition.z = Mathf.Round(transform.position.z);
        //ガイドの位置変更
        Guide.GetComponent<GuidePositionSetting>().SetGuidePosition(BlockPosition);
    }
    /// <summary>
    /// Blockを作成する
    /// 押したボタンによってBlockの向き変える
    /// </summary>
    /// <param name="TateYoko"></param>
    private void InstanceBlock(string TateYoko)
    {
        //横向きにBlock生成 資材の数が10以上あるなら
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
            Console.Write("クリック内容が存在しません");
            return ;
        }

        Wood.WoodNum -= 10;//木材減らす
        WoodIndicator.SetNum(Wood.WoodNum);//UIの木材の表示を変更する
    }

}
