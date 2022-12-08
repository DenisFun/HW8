using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsChange : MonoBehaviour
{
	[SerializeField]
	private People[] m_people;

	public void Action()
	{
		foreach (var item in m_people)
		{
			item.ChangeTool();
		}
	}
}
