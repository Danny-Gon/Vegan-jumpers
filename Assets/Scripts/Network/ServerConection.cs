using UnityEngine;
using Photon.Pun;

public class ServerConection : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnected()
    {
        base.OnConnected();
        print("Is Conected");
    }
 
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("Is Connected To Master");
        
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        print("Has Joined the Lobby");
    }
}
