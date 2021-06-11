using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CineMachine : MonoBehaviour {

    public GameObject player;

    public Vector2 minCamp, maxCamp;
    public float smoothTime;

    private Vector2 velocity;

    void Update()
    {

        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTime);

        transform.position = new Vector3(
        Mathf.Clamp(posX, minCamp.x, maxCamp.x),
        Mathf.Clamp(posY, minCamp.y, maxCamp.y),
        transform.position.z);
    }
}
