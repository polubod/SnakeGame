using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float MoveSpeed = 10;
    public float SteerSpeed = 180;

    public GameObject BodyPrefab;

    private List<GameObject> BodyParts = new List<GameObject>();
    // Start is called before the first frame update

    void Start()
    {
        GrowSnake();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward*MoveSpeed * Time.deltaTime;

        //steer
        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerDirection * SteerSpeed * Time.deltaTime);
        
    }

    private void GrowSnake(){
        GameObject body = Instantiate(BodyPrefab);
        BodyParts.Add(body);
    }
}
