using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
	[SerializeField] private TileMap m_TileMapPrefab;
	public TileMap TileMapInstance { get; private set; }

	public void LoadTileMap()
	{
		TileMapInstance = Instantiate(m_TileMapPrefab, transform);
		TileMapInstance.GenerateMap();
	}
}
