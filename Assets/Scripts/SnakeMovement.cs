using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    Apple apple;
    public float MoveSpeed = 15;
    public float SteerSpeed = 180;
    public float BodySpeed = 5;
    public GameObject BodyPrefab;
    public int Gap = 150;


    private List<GameObject> BodyParts = new List<GameObject>();
    private List<Vector3> PositionsHistory = new List<Vector3>();
    // Start is called before the first frame update

    void Start()
    {
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward*MoveSpeed * Time.deltaTime;

        //steer
        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerDirection * SteerSpeed * Time.deltaTime);
        
        PositionsHistory.Insert(0, transform.position);

        int index = 0;

        foreach (var body in BodyParts){
            Vector3 point = PositionsHistory[Mathf.Min(index * Gap, PositionsHistory.Count - 1)];
            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * BodySpeed * Time.deltaTime;
            body.transform.LookAt(point);
            //body.transform.position = point;
            index++;
            
        }
    }
    // public void OnTriggerEnter(Collider other){
    //     if(other.tag == "Enemy"){
    //         Destroy(other.gameObject);
    //         GrowSnake();
    //     }
    // }

    public void GrowSnake(){
        GameObject body = Instantiate(BodyPrefab);
        BodyParts.Add(body);
    }
}
