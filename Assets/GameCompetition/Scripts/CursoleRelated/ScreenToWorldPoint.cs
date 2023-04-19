//マウスのスクリーン座標をワールド座標に変換する
//オブジェクトの座標をマウス位置と同期する

using UnityEngine;
public class ScreenToWorldPoint : MonoBehaviour
{
    [Header("MouseのZ座標")]
    [SerializeField]
    float Mouse_z;

    //マウスカーソル消す
    private void Start() { Cursor.visible = false; }
    
    // Update is called once per frame
    private void Update()
    {
        Vector3 MousePos = Input.mousePosition;
        MousePos.z = Mouse_z;
        Vector3 ScreenPos = Camera.main.ScreenToWorldPoint(MousePos);
        transform.position = ScreenPos;
    }
}
