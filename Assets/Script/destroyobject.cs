using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobject : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);

        scoremanager.instance.AddPoint();
    }
}
