using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ZoneType {None, OddRSquare}
// An OddRSquare is 2D array that uses odd-offset row coordinates (see http://www.redblobgames.com/grids/hexagons/#coordinates)

public class Zone : MonoBehaviour {

  new public string name;
  public TileSet tileset;
  public readonly ZoneType zoneType;
  public Tile[,] tiles
  {
    get {return this.tiles;}
    set
    {
      this.tiles = value;
      this.width = tiles.GetLength(0);
    }
  }

  public int width { get; private set; }
  public readonly float waterHeight;
  public readonly static float sideLength;
  public static float root3 = Mathf.Sqrt(3);

  public Zone(string n, ZoneType t)
  {
    name = n;
    zoneType = t;
  }

	public static Zone GenerateFlatHexPlane(int width)
  {
    Zone output = new Zone("Flat Hex Zone", ZoneType.OddRSquare);
    output.tiles = new Tile[width, width];    // array of 0's
    return output;
  }
}
