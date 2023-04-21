//�Q�[�����J�n����
//�v���C���[�̍쐬�@�I�����C���J�n
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
public class GameStartExecution : MonoBehaviourPunCallbacks
{
    public bool isPlayer1 = false, isPlayer2 = false;
    [SerializeField]
    private Transform Player1InstancePosition, Player2InstancePosition; 
    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey(KeyCode.Q)) { 
            isPlayer1 = true;
            PhotonNetwork.ConnectUsingSettings();

        }
        if (Input.GetKey(KeyCode.E))
        {
            isPlayer2 = true;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    // �}�X�^�[�T�[�o�[�ւ̐ڑ��������������ɌĂ΂��R�[���o�b�N
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    // �Q�[���T�[�o�[�ւ̐ڑ��������������ɌĂ΂��R�[���o�b�N
    public override void OnJoinedRoom()//Room�����Ă����ԂŌĂяo����Ȃ��̂�2��ڂ�Player�͐�������Ȃ�
    {
        if (isPlayer1)
        {
            PhotonNetwork.Instantiate("Player1", Player1InstancePosition.position, Quaternion.identity);
        }
        else if (isPlayer2)
        {
            PhotonNetwork.Instantiate("Player2", Player2InstancePosition.position, Quaternion.identity);
        }
        else
        {
            return;
        }
    }


}
