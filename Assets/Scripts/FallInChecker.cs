using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallInChecker : MonoBehaviour {

    public Hole red;
    public Hole green;
    public Hole blue;

    private void OnGUI()
    {
        string label = " ";

        if (red.InFallIn() && green.InFallIn() && blue.InFallIn())
        {
            label = "Fall in hole";
        }
        GUI.Label(new Rect(0, 0, 100, 30), label);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
