using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{

    public MeshFilter CurrentTools;
    public Mesh NewTools;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CurrentTools.mesh = NewTools;
        }
    }
}