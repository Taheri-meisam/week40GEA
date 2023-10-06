using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoints : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] points;
    int currentPoint = 0;
    [SerializeField] float speed = 1.0f;
    [SerializeField] float rotationSpeed = 2.0f;
    public TestObject sObjectPlayer;
    public int lap = 0;
    void Start()
    {
        this.transform.Translate(sObjectPlayer.pos);
        sObjectPlayer.initObject();
        this.GetComponent<Renderer>().material = sObjectPlayer.mat;
        speed = sObjectPlayer.speed;
        rotationSpeed = sObjectPlayer.rotationSpeed;
        Debug.Log(sObjectPlayer.name);   

    }

    // Update is called once per frame
    void Update()
    {
        // check the distance to the way points in the array // if we get close to one, the go to the next 
        if (Vector3.Distance(this.transform.position, points[currentPoint].transform.position) < 2 )
        {
            currentPoint++;
        }

        //finish the lap, start the next lap 
        if (currentPoint >= points.Length)
        {
            currentPoint = 0;
            lap++;
        }
        Quaternion lookAtPoints = Quaternion.LookRotation(points[currentPoint].transform.position - this.transform.position); // smooth out the rotation 
        this.transform.rotation = Quaternion.Lerp(transform.rotation, lookAtPoints, rotationSpeed * Time.deltaTime); // interpolate bwteen two points 
        // this.transform.LookAt(points[currentPoint].transform.position );
        this.transform.Translate(0,0,speed * Time.deltaTime); // move 
        Debug.Log(this.name+ " Lap is : " + lap);
 
    }
}
