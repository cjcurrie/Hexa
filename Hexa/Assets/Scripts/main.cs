using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour {

  public Map currentMap;
  public MapRenderer mapRenderer;

	void Start () {
    mapRenderer.Initialize();

    currentMap = new Map();
    mapRenderer.RenderMap(currentMap);
	}

}
