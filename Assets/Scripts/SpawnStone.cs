using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStone : MonoBehaviour
{
    public GameObject Stone;
    public GameObject Pos;

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Destroy(Instantiate(Stone, Pos.transform.position, Quaternion.identity), 20f);
        }
    }
}