using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEJ_Flappy_Bird : MonoBehaviour
{
    public GameObject luffy;
    private Rigidbody2D luffyrb;
    public SpriteRenderer luffysr;
    public SpriteRenderer ceusr;
    public SpriteRenderer marsr;
    public SpriteRenderer solsr;
    private bool chaoz;
    public SpriteRenderer chaosr;
    void Start()
    {
     luffyrb=GetComponent<Rigidbody2D>();
     StartCoroutine(andar(luffysr));
     StartCoroutine(andar(chaosr));
     StartCoroutine(andar(ceusr));
     StartCoroutine(andar(marsr));
     StartCoroutine(andar(solsr));   
    }
    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey("up")&&chaoz==true){
        luffyrb.AddForce(new Vector2(0,10));
        chaoz=false;
      }
      print(chaoz);
    }


    IEnumerator andar(SpriteRenderer correr){
        while(true){
            correr.flipX=true;
            yield return new WaitForSeconds(0.1f);
            correr.flipX=false;
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void OnCollisionEnter2D(Collision2D pulo) {
        if(pulo.gameObject.tag=="chao"){
            chaoz=true;
            print("to no chao");
        }
        
    }
}
