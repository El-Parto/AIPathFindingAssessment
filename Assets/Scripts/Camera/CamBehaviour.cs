using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamBehaviour : MonoBehaviour
{
    public List<GameObject> agents = new List<GameObject>();
    private int agentNumber = 0;

    [SerializeField]
    private Camera mainCamera = new Camera();

    private Transform startPos;


    private void Awake()
    {
        
    }

    private void Start()
    {
        mainCamera = FindObjectOfType<Camera>();
        startPos = mainCamera.transform;
        mainCamera.transform.position = startPos.position;

    }




    // Update is called once per frame
    void Update()
    {
        
    }

    public void AgentSwitch(int i)
    {
        agentNumber = i;
        mainCamera.transform.position = new Vector3(0, startPos.transform.position.y, 0);
        mainCamera.transform.SetParent(agents[agentNumber].transform, false);
    }
    public void Overhead()
    {
        mainCamera.transform.SetParent(null, false);
        mainCamera.transform.position = new Vector3(startPos.position.x, startPos.position.y, startPos.position.z);
    }
}
