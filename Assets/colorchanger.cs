using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchanger : MonoBehaviour {
  public int h, s, v;
    Color c = new Color();
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //  this.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        this.GetComponent<Renderer>().material.color = c;

    }
    public void ChangeColor(int H,int S,int V){
       
        Debug.Log("called");
        h = H;
        s = S;
        v = V;
        c.r = H;
        c.g = S;
        c.b = V;
        this.GetComponent<Renderer>().material.color = c;
    }
}
