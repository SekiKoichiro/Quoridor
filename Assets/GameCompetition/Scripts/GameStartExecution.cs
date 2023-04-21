//ゲームを開始する
//プレイヤーの作成　オンライン開始
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

    // マスターサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    // ゲームサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnJoinedRoom()//Room入っている状態で呼び出されないので2回目にPlayerは生成されない
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
