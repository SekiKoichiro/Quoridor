//ガイドの位置座標を変更する
using UnityEngine;

public class GuidePositionSetting : MonoBehaviour
{
    public void SetGuidePosition(Vector3 pos)
    {
        transform.position = pos;
    }
}
