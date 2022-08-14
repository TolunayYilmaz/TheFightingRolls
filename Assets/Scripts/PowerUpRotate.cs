using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRotate : MonoBehaviour
{



    void Update()
    {
        transform.Rotate(new Vector3(0, 100 * Time.deltaTime, 0));//It turns around and attracts the attention of the player.

    }
}
