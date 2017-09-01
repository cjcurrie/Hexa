using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapLabel : MonoBehaviour {

	public Text cellLabelPrefab;

  Canvas gridCanvas;
  Transform canvTrans;

  public void Initialize(){
    gridCanvas = GameObject.FindWithTag("MainCamera").GetComponentInChildren<Canvas>();
    canvTrans = gridCanvas.transform;
  }

  public void AddLabel(Transform t, string text)
  {
    Text label = Instantiate<Text>(cellLabelPrefab);
    label.rectTransform.SetParent(canvTrans, false);
    label.rectTransform.position = new Vector3(t.position.x, 1, t.position.z);
    label.text = text;
  }
}
