using UnityEngine;
using System.Collections;

public class HorizontalPacer : MonoBehaviour
{

    public float speed;
    private float xMax = 5f;

    private float xMin = -5f; //starting position
    private int direction = 1; //positive to start

    void Update()
    {
        float xNew = transform.position.x +
        direction * speed * Time.deltaTime;
        if (xNew >= xMax)
        {
            xNew = xMax;
            direction *= -1;
        }
        else if (xNew <= xMin)
        {
            xNew = xMin;
            direction *= -1;
        }
        transform.position = new Vector3(xNew, 0.5f, -5f);
    }
}
