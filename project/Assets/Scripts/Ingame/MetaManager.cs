using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaManager : MonoBehaviour
{
	[SerializeField] World m_GameWorldPrefab;
	public World GameWorldInstance { get; private set; }

	public void LoadWorld()
	{
		GameWorldInstance = Instantiate(m_GameWorldPrefab, transform);
	}

	private void Awake()
	{
		LoadWorld();
		GameWorldInstance.LoadTileMap();
	}
}
