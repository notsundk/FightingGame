using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCameraFollow : MonoBehaviour
{
    public GameObject targetToFollow;
    public Vector3 targetPosition;

    void Update()
    {
        targetPosition = new Vector3(gameObject.transform.position.x, targetToFollow.transform.position.y, gameObject.transform.position.z);
        Vector3 currentPosition = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        gameObject.transform.position = Vector3.Lerp(currentPosition, targetPosition, 0.1f);
    }
}