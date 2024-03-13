using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float playerJumpForce = 30f;
    public float playerSpeed = 5f;
    public Sprite[] mySprites;
    private int index = 0;

    private Rigidbody2D myrigidbody2D;
    private SpriteRenderer mySpriteRenderer;
    public GameManager myGameManager;
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(WalkCoRoutine());
        myGameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) ){
            
            jump();
        }

        myrigidbody2D.velocity = new Vector2(playerSpeed, myrigidbody2D.velocity.y);

        
        if(Input.GetKeyDown(KeyCode.E) ){
            Instantiate(fire, transform.position, Quaternion.identity);
        }
        
    }

    void jump(){
        myrigidbody2D.velocity = new Vector2(myrigidbody2D.velocity.x, playerJumpForce);
    }

    IEnumerator WalkCoRoutine(){
        yield return new WaitForSeconds(0.05f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if(index == mySprites.Length){
            index = 0;
        }
        StartCoroutine(WalkCoRoutine());
    }


    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("ItemGood"))
        {
            Destroy(collision.gameObject);
            myGameManager.AddScore();
        }else if(collision.CompareTag("ItemBad"))
        {
            Destroy(collision.gameObject);
            PlayerDeath();
        }else if(collision.CompareTag("DeathZone"))
        {
            PlayerDeath();
        }
    }

    void PlayerDeath()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
