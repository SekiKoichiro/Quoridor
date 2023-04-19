//ゴールしたか判定する
//nameに初めに当たったプレイヤー名入れ、異なる名前のプレイヤー名が当たったときゴールとする
//GoalDiplayをアタッチする
using UnityEngine;

public class GoalJudge : MonoBehaviour
{
    private string name = null,playertag = "Player";
    [SerializeField]
    private GoalDisplay goaldisplay;
    private void OnTriggerEnter(Collider other)
    {
        if (name == null && other.gameObject.tag == playertag) { name = other.gameObject.name; }//初め当たったプレイヤーの名前取得
        else if(name !=  null && other.gameObject.tag == playertag && name == other.gameObject.name){//ゴール判定
            goaldisplay.DisplayName();
        }
    }
}
