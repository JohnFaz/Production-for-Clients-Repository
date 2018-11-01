using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public GameObject currentCanvas;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //need to set canvas most recently enabled as "current canvas" for SwitchCanvas script, to avoid hard coding 'change month' buttons
    }
}
