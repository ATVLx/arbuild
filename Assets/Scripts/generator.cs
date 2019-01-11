using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class generator : MonoBehaviour {
    public GameObject cube,rectcube,plane,sphere,Parent,heirarchy,inspector,buildingdoorsideg,building2,building3,building4,props1,props2,props3,props4;

	// Use this for initialization
	void Start () {
       // transform.parent = Parent.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void  CreateCube()
    {
        Instantiate(cube,Parent.transform);
    }
    public void CreateCubeRect()
    {
        Instantiate(rectcube, Parent.transform);
    }
    public void CreatePlane()
    {
        Instantiate(plane, Parent.transform);
    }
    public void CreateSphere()
    {
        Instantiate(sphere, Parent.transform);
    }
    public void Buildingdoorside()
    {
        Instantiate(buildingdoorsideg, Parent.transform);
    }
    public void Building1()
    {
        Instantiate(building2, Parent.transform);
    }
    public void Building2()
    {
        Instantiate(building3, Parent.transform);
    }
    public void Building3()
    {
        Instantiate(building4, Parent.transform);
    }
    public void OnchangeColor(){
        FindObjectOfType<clicker>().Status(true);
        FindObjectOfType<LeanSelect>().OnchangeColor(1, 0, 1);

    }
    public void OntoggleDetailView(){
        if (heirarchy.activeInHierarchy == true && inspector.activeInHierarchy == true)
        {
            heirarchy.SetActive(false);
            inspector.SetActive(false);

        }
        else{
            heirarchy.SetActive(true);
        inspector.SetActive(true);
        }
    }
}
