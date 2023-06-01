using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEJ_Flappy_Bird : MonoBehaviour
{
    public GameObject luffy;
    private Rigidbody2D luffyrb;
    public SpriteRenderer luffysr;
    void Start()
    {
     luffyrb=GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
