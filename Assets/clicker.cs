using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicker : MonoBehaviour
{
    [SerializeField]
    private LayerMask clickable;
    public int h, s, v;
    bool changing = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetColor(int h1,int s1,int v1){
        h = h1;
        s = s1;
        v = v1;

    }
    public void Status(bool status)
    {
        changing = status;
    }

}
