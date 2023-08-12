using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;


    private void Start()
    {
        // x position between left & right border
        int x = (int)Random.Range(borderLeft.position.x,
                              borderRight.position.x);

        // y position between top & bottom border
        int y = (int)Random.Range(borderBottom.position.y,
                                  borderTop.position.y);

        PhotonNetwork.Instantiate(playerPrefab.name, new Vector2(x, y), Quaternion.identity);
    }
}
