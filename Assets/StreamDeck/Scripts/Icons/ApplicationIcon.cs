using UnityEngine;
using System.Collections;

public class ApplicationIcon : MonoBehaviour, IActionIcon {

    public string executable;

    public void ExecuteAction() {
        System.Diagnostics.Process.Start(executable);
    }
}
