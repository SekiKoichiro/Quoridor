//�}�E�X�̃X�N���[�����W�����[���h���W�ɕϊ�����
//�I�u�W�F�N�g�̍��W���}�E�X�ʒu�Ɠ�������

using UnityEngine;
public class ScreenToWorldPoint : MonoBehaviour
{
    [Header("Mouse��Z���W")]
    [SerializeField]
    float Mouse_z;

    //�}�E�X�J�[�\������
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
