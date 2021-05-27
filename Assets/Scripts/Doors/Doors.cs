using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    //    public Vector3 doorsPlus; 


    //[SerializeField] private Vector3 doorsPlus; //Start Position
    public Transform noFuss; // end position


    [SerializeField] private Vector3 doorsPlus; // this will take in the current position of an object using a vector3
    //[SerializeField] private Transform endpos; // This will set the endposition via a transform class (the transform rect)

    private Vector3 start; // a vector3 variable to set the start position
    private Vector3 end; // a vector3 variable to set the end position

    //public float timer = 5;

    [SerializeField]
    private float moveSpeed = 1f;
    [SerializeField]
    private float waitTime = 1f;

    public float factor => Mathf.PingPong(Time.time * moveSpeed, waitTime); // a new variable float is equal to a mathf class that calls upon the pingpong function, for the object to move back and forth from (thanks (teacher)James!)

    // Start is called before the first frame update
    void Start()
    {
        doorsPlus = gameObject.transform.position;
        start = doorsPlus; // the start variable now is equal to the doorsplus variable.
        end = noFuss.position; // and the  end is now equal to the endpos position   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(start, end, factor); // moving the object using linear interpolation between the variable start and end by a factor of mathF pingpong. (again. Thanks James!)
        //StartCoroutine(DoorTimer());
    }

    //public void OpenSesame()
    //{


    //}

   //// IEnumerator DoorTimer()
   // {
        
        
        

   // }


  

}
