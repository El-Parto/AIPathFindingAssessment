using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Controls the camera position based on what button is selected.
/// Turns off game if selected Quit
/// </summary>
public class CamBehaviour : MonoBehaviour
{
    public List<GameObject> agents = new List<GameObject>(); // a list of game objects that is applied in the inspector they take in the agents
    private int agentNumber = 0; // the number of the agent in the list

    [SerializeField]
    private Camera mainCamera = new Camera(); // mainCamera

    [SerializeField]
    private Transform startPos;// the starting position for the main camera stored as a transform variable.

    private void Start()
    {
        mainCamera = FindObjectOfType<Camera>();        
        mainCamera.transform.position = startPos.position;
    }
    /// <summary>
    /// Based on which button you click,  the camera will set itself to the child
    /// of the game object's transform base on their order in the list (as denoted by i)
    /// </summary>
    /// <param name="i"> The agent's number associated in the inspector. </param>
    public void AgentSwitch(int i)
    {
        agentNumber = i; // Agent number from list equals local variable i
        Overhead(); // Not entirely sure why the math cheecks out here, but putting this here makes it "reset" so it can do the math better?
        mainCamera.transform.position = new Vector3(0, startPos.transform.position.y, 0);
        mainCamera.transform.SetParent(agents[agentNumber].transform, false); // sets the parent of the main camera to the agent number selected based on what button was selected
    }

    /// <summary>
    /// sets the camera back to the "default" position.
    /// </summary>
    public void Overhead()
    {
        mainCamera.transform.SetParent(null, false);
        mainCamera.transform.position = new Vector3(startPos.position.x, startPos.position.y, startPos.position.z);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

