using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{

    //private int index = 0;
    //public Sprite[] mySprites;

    private Rigidbody2D myrigidbody2D;
    public float bulletSpeed = 15f;
    //private SpriteRenderer mySpriteRenderer;
    public GameManager myGameManager;

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        //mySpriteRenderer = GetComponent<SpriteRenderer>();
        myGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody2D.velocity = new Vector2(bulletSpeed, myrigidbody2D.velocity.y);  
        //StartCoroutine(FireCoRoutine());      
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("ItemGood"))
        {
            Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);

        }else if(collision.CompareTag("ItemBad"))
        {
            myGameManager.AddScore();
            Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);
        }
    }

    /*IEnumerator FireCoRoutine(){
        yield return new WaitForSeconds(0.05f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if(index == mySprites.Length){
            index = 0;
        }
        StartCoroutine(FireCoRoutine());
    }*/
}
