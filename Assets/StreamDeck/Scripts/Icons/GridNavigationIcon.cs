using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridNavigationIcon : MonoBehaviour, IActionIcon {
    public int gridIndex;
	public void ExecuteAction() {
        GridManager.instance.SwapIconCollection(gridIndex);
    }
}
