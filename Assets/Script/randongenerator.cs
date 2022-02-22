using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randongenerator : MonoBehaviour
{
    public GameObject bag;
    public GameObject bottle;
    public GameObject box;
    public GameObject ceramicup;
    public GameObject clean;
    public GameObject colacan;
    public GameObject beerbottle;
    public GameObject glassbottle;
    public GameObject jar;
    public GameObject milk;
    public GameObject newspaper;
    public GameObject pizzatime;
    public GameObject sippycup;
    public GameObject spraycan;
    public GameObject alucan;
    public GameObject tincan;
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
            Instantiate(ceramicup, spawnPosition, Quaternion.identity);
            Instantiate(clean, spawnPosition, Quaternion.identity);
            Instantiate(colacan, spawnPosition, Quaternion.identity);
            Instantiate(beerbottle, spawnPosition, Quaternion.identity);
            Instantiate(glassbottle, spawnPosition, Quaternion.identity);
            Instantiate(jar, spawnPosition, Quaternion.identity);
            Instantiate(milk, spawnPosition, Quaternion.identity);
            Instantiate(newspaper, spawnPosition, Quaternion.identity);
            Instantiate(pizzatime, spawnPosition, Quaternion.identity);
            Instantiate(sippycup, spawnPosition, Quaternion.identity);
            Instantiate(spraycan, spawnPosition, Quaternion.identity);
            Instantiate(alucan, spawnPosition, Quaternion.identity);
            Instantiate(tincan, spawnPosition, Quaternion.identity);
        }
    }

}
