using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    private GameObject player;
    private Vector3 followPosition;

    void Start()
    {
        player = GameObject.FindWithTag("PositionControler");
        followPosition = new Vector3(0,8,-1);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + followPosition;
    }
}
