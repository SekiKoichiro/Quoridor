//Player‚ğƒL[“ü—Í‚ÅˆÚ“®‚³‚¹‚é
using UnityEngine;
using System;
public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float force;
    private Rigidbody rb;
    private bool SpeedIs;
    void Start()
    {
        
        rb = this.transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity.magnitude < 1)
        {
            if (Input.GetKey(KeyCode.D)) MoveRight();
            if (Input.GetKey(KeyCode.A)) MoveLeft();
            if (Input.GetKey(KeyCode.W)) MoveUp();
            if (Input.GetKey(KeyCode.S)) MoveDown();
        }
    }
    //ˆÚ“®§Œä
    private void MoveRight() {rb.AddForce(0f, 0f, -force); }
    private void MoveLeft() { rb.AddForce(0f, 0f, force); }
    private void MoveUp() { rb.AddForce(force, 0f, 0f); }
    private void MoveDown() { rb.AddForce(-force, 0f, 0f); }

}
