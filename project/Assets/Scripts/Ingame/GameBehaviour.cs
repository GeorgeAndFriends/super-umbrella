using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
	public MetaManager MetaManager => m_MetaManager != null ? m_MetaManager : m_MetaManager = GetComponentInParent<MetaManager>();
	private MetaManager m_MetaManager;
}
