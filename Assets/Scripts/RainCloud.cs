using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCloud : MonoBehaviour
{

    public Transform[] Human;
    public Transform Cloud;
    public ParticleSystem Rain;
	public float SpeedMove = 10f;
    int i = 0;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            transform.position = Vector3.MoveTowards(transform.position, Human[i].position, SpeedMove * Time.deltaTime);
            if(transform.position == Human[i].position)
            {
                i++;
            }
            if(i > 5) i = 0;
        }
    }
	
}
