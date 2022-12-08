using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConroller : MonoBehaviour
{
	[SerializeField]
	private SpawnStone m_spawnStone;
	[SerializeField]
	private CloudController m_cloudController;
	[SerializeField]
	private ToolsChange m_toolsChange;
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
		{
			m_spawnStone.Spawn();
		}

		if(Input.GetKeyDown(KeyCode.Z))
		{
			m_cloudController.Action();
		}
		if(Input.GetKeyDown(KeyCode.Space))
		{
			m_toolsChange.Action();
		}
    }
}
