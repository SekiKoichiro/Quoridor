//Playerをキー入力で移動させる
using UnityEngine;
using Photon.Pun;
public class PlayerControl : MonoBehaviourPunCallbacks
{
    [SerializeField] private float force;
    private Rigidbody rb;
    private bool isSpeed;
    void Start()
    {
        
        rb = this.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //自分が生成したオブジェクトのみに移動処理実施する
        if (rb.velocity.magnitude < 1 && photonView.IsMine )
        {
            if (Input.GetKey(KeyCode.D)) MoveRight();
            if (Input.GetKey(KeyCode.A)) MoveLeft();
            if (Input.GetKey(KeyCode.W)) MoveUp();
            if (Input.GetKey(KeyCode.S)) MoveDown();
        }
    }
    //移動制御
    private void MoveRight() {rb.AddForce(0f, 0f, -force); }
    private void MoveLeft() { rb.AddForce(0f, 0f, force); }
    private void MoveUp() { rb.AddForce(force, 0f, 0f); }
    private void MoveDown() { rb.AddForce(-force, 0f, 0f); }

}
