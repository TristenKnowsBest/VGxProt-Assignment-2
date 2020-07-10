using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    Transform[] waypoints2;

    int index = 0;
    int index2 = 0;
    bool firstArray = true;
    bool secondArray = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[index].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move(){
        if(firstArray == true){
            transform.position = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, 5 * Time.deltaTime);
        }
        if(secondArray == true){
            transform.position = Vector3.MoveTowards(transform.position, waypoints2[index2].transform.position, 5 * Time.deltaTime);
        }
        if(transform.position == waypoints[index].transform.position && secondArray == false){
            index = index + 1;
            firstArray = true;
        }
        
        if(index == waypoints.Length){
            index = 0;
            firstArray = false;
            secondArray = true;
        }

        if(transform.position == waypoints2[index2].transform.position && firstArray == false){
            index2 = index2 + 1;
            secondArray = true;
        }
        
        if(index2 == waypoints2.Length){
            index2 = 0;
            secondArray = false;
            firstArray = true;
        }

    }
}
