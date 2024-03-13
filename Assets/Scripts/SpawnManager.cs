using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefab;

    public float minTime = 1f;
    public float maxTime = 2f;

    public GameObject objeto;
    
    public GameManager myGameManager;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoRoutine(0));   
    }

    IEnumerator SpawnCoRoutine(float waitTime){
        yield return new WaitForSeconds(waitTime);
        objeto = itemPrefab[Random.Range(0, itemPrefab.Length)];
        var newObject = (GameObject) Instantiate(objeto, transform.position, Quaternion.identity);
        StartCoroutine(SpawnCoRoutine(Random.Range(minTime, maxTime)));
    }





}
