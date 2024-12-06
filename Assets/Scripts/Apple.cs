using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public SnakeMovement snakemovement;
    public GameObject applePrefab;
    // Start is called before the first frame update
    void Start()
    {
        spawnApple();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
    void spawnApple(){
        float randomXPosition = Random.Range(-74f, 74f);
        float randomZPosition = Random.Range(-74f, 74f);
        Vector3 spawnPosition = new Vector3(x: randomXPosition, y:5f, randomZPosition);
        Instantiate(applePrefab, spawnPosition, Quaternion.identity);
    }

    // private void OnTriggerEnter(Collider other){

    //     // Renderer render = GetComponent<Renderer>();
    //     // render.material.color = Color.green;
    //     if(other.ameObject.CompareTag == "Enemy"){
    //         Destroy(other.gameObject);
    //     }
    //         //snakemovement.GrowSnake();
        
    // }
}
