using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    //    public Vector3 doorsPlus; 


    [SerializeField] private Vector3 doorsPlus; //Start Position
    public Transform noFuss; // end position
    

    //public float timer = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(doorTimer());
    }

    public void OpenSesame(float _yPos)
    {
        
        gameObject.transform.position += new Vector3(0, _yPos, 0) * Time.deltaTime;
        
    }

    IEnumerator doorTimer()
    {     
    
    OpenSesame(-5);
    
    yield return new WaitForSeconds(5);
    OpenSesame(+5);
    
    }


  

}
