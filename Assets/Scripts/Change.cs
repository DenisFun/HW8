using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{

    public MeshFilter CurrentTools;
    public Mesh NewTools;
    public void ChangeTools()
    {
            CurrentTools.mesh = NewTools;
    }
}
