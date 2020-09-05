using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
	[SerializeField] private TileCatalog m_TileCatalog;
	[SerializeField] private Tile m_TilePrefab;
	public int MapSize => m_MapSize;
	[SerializeField] private int m_MapSize;
	public int TileSize => m_TileSize;
	[SerializeField] private int m_TileSize;
	
	// x, y position of the tile stack. layer, tile instance
	public Dictionary<(int, int), Dictionary<int, Tile>> TilesByPosition = new Dictionary<(int, int), Dictionary<int, Tile>>();

	public void GenerateMap()
	{
		for (int y = 0; y < m_MapSize; y++)
		{
			for (int x = 0; x < m_MapSize; x++)
			{
				var layer = new Dictionary<int, Tile>();
				var base_layer = m_TileCatalog.TileLayers[0];
				var tile = Instantiate(base_layer.Tiles[Random.Range(0, base_layer.Tiles.Count)], transform);
				tile.transform.localPosition = new Vector3(m_TileSize * y, 0.0f, m_TileSize * x);
				tile.name = $"TILE:{x}_{y}";
				tile.Setup(x, y);

				layer.Add(base_layer.Id, tile);
				TilesByPosition.Add((x,y), layer);
			}
		}
	}
}
