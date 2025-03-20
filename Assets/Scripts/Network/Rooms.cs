using System;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class Rooms : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField joinInputField, createInputField;
    [SerializeField] private string roomName;

    private void Start()
    {
        joinInputField?.onValueChanged.AddListener(text => { roomName = text;});
        createInputField?.onValueChanged.AddListener(text => { roomName = text;});
    }

    [ContextMenu("Create")]
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(roomName);
    }

    [ContextMenu("Join")]
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(roomName);
    }
    
    [ContextMenu("Leave")]
    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
        print("Room Created!");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
        print($"Room Connection Failed!\nCode: {returnCode}, Error: {message}");
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        print($"Has Connected To Room{PhotonNetwork.CurrentRoom.Name}!");
        PhotonNetwork.LoadLevel("2.PistaLateral");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
        print($"Room Connection Failed!\nCode: {returnCode}, Error: {message}");
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        print($"Has Left The Room!");
    }
}
