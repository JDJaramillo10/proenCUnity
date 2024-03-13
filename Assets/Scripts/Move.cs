using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Move : MonoBehaviour
{
   
    public Sprite[] mySprites;
    private int index = 0;

    private SpriteRenderer mySpriteRenderer;
    private GameManager myGameManager;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(IdleCoRoutine());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator IdleCoRoutine(){
        yield return new WaitForSeconds(0.08f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if(index == mySprites.Length){
            index = 0;
        }
        StartCoroutine(IdleCoRoutine());
    }

    

}
