using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTile : Tile
{
	[SerializeField] private float m_GrassPerlinScale = 0.1f;
	[SerializeField] private List<Sprite> GrassSprites;

	public override void Setup(int x, int y)
	{
		base.Setup(x, y);
		float map_size = MetaManager.GameWorldInstance.TileMapInstance.MapSize;
		float perlin = Mathf.Clamp01(Mathf.PerlinNoise((x / map_size) * m_GrassPerlinScale, (y / map_size) * m_GrassPerlinScale));
		int index = Mathf.FloorToInt(perlin * GrassSprites.Count);
		SpriteRenderer.sprite = GrassSprites[index];
	}
}
