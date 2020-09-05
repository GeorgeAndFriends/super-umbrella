using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : GameBehaviour
{
	public SpriteRenderer SpriteRenderer;
	public (int, int) Position { get; private set; }
	public virtual void Setup(int x, int y)
	{
		Position = (x, y);
	}
}
