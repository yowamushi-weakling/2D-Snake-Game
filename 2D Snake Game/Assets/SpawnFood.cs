using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject foodPrefeb;

    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    // Spawn one piece of food
    void Spawn()
    {
        // x position between left & right border
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.y);

        // y position between top & bottom border
        int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);

        // Instantiate the food at (x, y)
        Instantiate(foodPrefeb, new Vector2(x, y), Quaternion.identity); // default rotation
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawn food every 4 seconds, starting in 3
        InvokeRepeating("Spawn", 3, 4);
    }
}
