//ブロックを生成する
//マウスの位置取得
//ガイドの位置変更
//ガイドがBlockに触れているか判定
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
        //カーソルが移動したらカーソル移動を反映する
        if (BlockPosition.x != Mathf.Round(transform.position.x) || BlockPosition.z != Mathf.Round(transform.position.z)){ CheckRepositioned(); }
        
        //左クリック時に右向きにBlockを生成する
        if (Input.GetMouseButtonDown(0) && YokoIs.GetComponent<BlockEstablishmentPossibilityJudgment>().YokoIs)
        {
            InstanceBlockYoko();
        }
        //左クリック時に縦向きにBlockを生成する
        if (Input.GetMouseButtonDown(1) && TateIs.GetComponent<BlockEstablishmentPossibilityJudgment>().TateIs)
        {
            InstanceBlockTate();
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
    //Block作成
    private void InstanceBlockYoko()
    {
        //プロパティの使い方合っているか?
        if ( Wood.WoodNum >= 10)
        {
            GameObject obj = Instantiate(Block, BlockPosition, Quaternion.identity, parent);
            obj.name = "BlockA";
            Wood.WoodNum -= 10;//木材減らす
            WoodIndicator.SetNum(Wood.WoodNum);//UIの木材の表示を変更する
        }

    }

    private void InstanceBlockTate()
    {
        //プロパティの使い方合っているか?
        if (Wood.WoodNum >= 10)
        {
            GameObject obj = Instantiate(Block, BlockPosition, Quaternion.Euler(0, 90, 0), parent);
            obj.name = "BlockA";
            Wood.WoodNum -= 10;
            WoodIndicator.SetNum(Wood.WoodNum);//UIの木材の表示を変更する
        }
    }

}
