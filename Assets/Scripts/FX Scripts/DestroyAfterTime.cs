using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float Timer = 2f;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, Timer);               
    }

}