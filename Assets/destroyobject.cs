using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobject : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    //this is the destroy script, pretty self explanatory
    //just remember to add this to the game objects that has to be destroyed
}
