﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omCllision_test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name);
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
