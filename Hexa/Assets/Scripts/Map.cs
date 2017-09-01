using UnityEngine;
using System.Collections;

enum MapType {none, Flat};

public class Map {

  public int width = 6;
  public int height = 6;
  
  public HexCell[] cells;
  
	public Map()
  {
    GenerateMap(MapType.Flat);
  }

  void GenerateMap(MapType type)
  {
    cells = new HexCell[height * width];

    for (int z = 0, i = 0; z < height; z++) {
      for (int x = 0; x < width; x++, i++) {
        Vector3 position = new Vector3(x * HexMetric.outerRadius, 0, z * HexMetric.outerRadius);
        cells[i] = new HexCell(position);
      }
    }
  }
}
