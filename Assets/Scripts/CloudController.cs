using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
	[SerializeField]
	private Cloud m_cloud;
	[SerializeField]
	private Transform[] m_human;
	private Transform m_currentHuman;
	private int m_currentHumanIndex = 0;
	[SerializeField]
	private float m_speed = 5f;

	public void Action()
	{
		if (m_currentHuman == null)
		{
			m_cloud.StopRain();
			m_currentHuman = m_human[m_currentHumanIndex];

			if (++m_currentHumanIndex >= m_human.Length)
			{
				m_currentHumanIndex = 0;
			}
		}
	}
private void Update()
	{
		MoveToHuman();
	}

	private void MoveToHuman()
	{
		if (m_currentHuman != null)
		{
			var cloudPos = m_cloud.transform.position;
			var pos = m_currentHuman.position;
			pos.y = cloudPos.y;
			cloudPos = Vector3.Lerp(cloudPos, pos, Time.deltaTime * m_speed);
			if (Vector3.Distance(cloudPos, pos) < 0.1f)
			{
				m_currentHuman = null;
				OnMoveComplete();
			}
			m_cloud.transform.position = cloudPos;
		}
	}

	private void OnMoveComplete()
	{
		m_cloud.PlayRain();
	}

}
