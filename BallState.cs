using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallState : MonoBehaviour
{
    public bool dropped = false;
    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.tag == "drop")
        {
            dropped = true;
        }

    }


}

