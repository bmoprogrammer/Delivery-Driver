using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    // Having camera's position follow the car's position

    [SerializeField] GameObject objectToFollow;

    // Create a reference if we want to access/change/call an object's properties
    void LateUpdate()
    {
        transform.position = objectToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
