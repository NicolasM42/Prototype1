using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Camera tpCamera;
    public Camera fpCamera;
    public KeyCode switchKey;
    public GameObject player;
    private Vector3 tpOffset = new Vector3(0, 5, -10);
    private Vector3 fpOffset = new Vector3(0, 2, 0.5f);

    // Start is called before the first frame update
    void Start()
    {
        tpCamera.enabled = true;
        fpCamera.enabled = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(switchKey))
        {
            tpCamera.enabled = !tpCamera.enabled;
            fpCamera.enabled = !fpCamera.enabled;

        }

        tpCamera.transform.position = player.transform.position + tpOffset;

        fpCamera.transform.position = player.transform.position + fpOffset;
        fpCamera.transform.rotation = player.transform.rotation;
    }
}
