using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebIcon : MonoBehaviour, IActionIcon {

    public string url;

    public void ExecuteAction() {
        Debug.Log($"opening: {url}");
        Application.OpenURL(url);
    }
}
