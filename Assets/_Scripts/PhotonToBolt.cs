using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PhotonToBolt : MonoBehaviourPunCallbacks
{
    [Header("Trigger Events Names")]
    [ReadOnly]
    public string _OnConnectedToMaster = "OnConnectedToMaster";
    public string _OnDisconnected = "OnDisconnected";
    public string _OnJoinedLobby = "OnJoinedLobby";
    public string _OnJoinedRoom = "OnJoinedRoom";
    public string _OnJoinRandomFailed = "OnJoinRandomFailed";

    public override void OnConnectedToMaster()
    {
        CustomEvent.Trigger(gameObject, _OnConnectedToMaster);
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        CustomEvent.Trigger(gameObject, _OnDisconnected, cause);
    }
    public override void OnJoinedLobby()
    {
        CustomEvent.Trigger(gameObject, _OnJoinedLobby);
    }
    public override void OnJoinedRoom()
    {
        CustomEvent.Trigger(gameObject, _OnJoinedRoom);
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        CustomEvent.Trigger(gameObject, _OnJoinRandomFailed, returnCode, message);
    }
}
