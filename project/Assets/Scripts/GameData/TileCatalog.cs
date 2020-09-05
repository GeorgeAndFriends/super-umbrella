using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="TileCatalog", menuName ="Game/GameData/TileCatalog")]
public class TileCatalog : ScriptableObject, ISerializationCallbackReceiver
{
	[System.Serializable]
	public class TileLayer
	{
		public int Id;
		public int Layer;
		public List<Tile> Tiles;
	}

	public Dictionary<int, TileLayer> TileLayers = new Dictionary<int, TileLayer>();

	[SerializeField] private List<TileLayer> m_TileLayerData = new List<TileLayer>();

	public int SelectRandomTileLayerId()
	{
		return m_TileLayerData[Random.Range(0, m_TileLayerData.Count)].Id;
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
		TileLayers.Clear();
		foreach (var layer in m_TileLayerData)
		{
			TileLayers.Add(layer.Id, layer);
		}
	}
}
