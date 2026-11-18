using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
public Transform follower;
public Transform leader;

    void Update()
    {
        follower.position = leader.position;
    }
}
