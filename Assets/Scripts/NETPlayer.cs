using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NETPlayer : NetworkBehaviour
{
    // Start is called before the first frame update
    public NetworkVariable<Vector3> Position = new NetworkVariable<Vector3>();

    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
          //  Move();
        }
    }

    [ServerRpc]
    void SubmitPositionRequestServerRpc(ServerRpcParams rpcParams = default)
    {
        Position.Value = GetRandomPositionOnPlane();
    }

    static Vector3 GetRandomPositionOnPlane()
    {
        return new Vector3(Random.Range(-3f, 3f), 1f, Random.Range(-3f, 3f));
    }

    void Update()
    {
      //  transform.position = Position.Value;
    }

}

