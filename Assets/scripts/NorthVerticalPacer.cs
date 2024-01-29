using UnityEngine;
using System.Collections;

public class NorthVerticalPacer : MonoBehaviour
{

    public float speed;
    private float zMax = 27f;

    private float zMin = 13f; //starting position
    private int direction = 1; //positive to start

    void Update()
    {
        float zNew = transform.position.z +
        direction * speed * Time.deltaTime;
        if (zNew >= zMax)
        {
            zNew = zMax;
            direction *= -1;
        }
        else if (zNew <= zMin)
        {
            zNew = zMin;
            direction *= -1;
        }
        transform.position = new Vector3(-7.0f, 0.5f, zNew);
    }
}
