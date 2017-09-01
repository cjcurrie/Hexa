using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MapLabel))]
public class MapRenderer : MonoBehaviour
{
  public Transform cellPrefab;

  Transform[] cellSprites;
  MapLabel labels;
  Transform myTrans;

  public void Initialize(){
    myTrans = transform;
    labels = GetComponent<MapLabel>();

    labels.Initialize();
  }

  public void RenderMap(Map map)
  {
    cellSprites = new Transform[map.cells.Length];

    for (int z = 0, i = 0; z < map.height; z++) {
      for (int x = 0; x < map.width; x++, i++) {
        Transform cell = Instantiate<Transform>(cellPrefab);
        cell.SetParent(myTrans, false);
        cell.localPosition = map.cells[i].position;

        // Add coordinates to hexes
        labels.AddLabel( cell, x.ToString() + "\n" + z.ToString() );
        cellSprites[i] = cell;
      }
    }
  }
}
