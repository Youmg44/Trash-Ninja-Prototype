using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randongenerator : MonoBehaviour
{
    public GameObject bag;
    public GameObject bottle;
    public GameObject box;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
            float spawnX = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(bag,spawnPosition, Quaternion.identity);
            Instantiate(bottle, spawnPosition, Quaternion.identity);
            Instantiate(box, spawnPosition, Quaternion.identity);
        }
    }

}
