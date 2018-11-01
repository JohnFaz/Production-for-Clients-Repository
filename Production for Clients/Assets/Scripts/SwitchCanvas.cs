using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchCanvas : MonoBehaviour {

    public GameObject currentCanvas;
    public GameObject canvasToSwitchTo;


	public void SwapCanvas()
    {
        currentCanvas.SetActive(false);
        canvasToSwitchTo.SetActive(true);
    }
}
