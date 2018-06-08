using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class GridManager : MonoBehaviour {
    public static GridManager instance;
    public IconCollection[] iconCollections;
    public int collectionIndex = 0;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void SwapIconCollection(int index) {
        collectionIndex = index;
        for(int i = 0; i < iconCollections.Length; i++) {
            if(i == index) {
                for (int j = 0; j < iconCollections[i].actionIcons.Length; j++) {
                    iconCollections[i].actionIcons[j].GetComponent<VirtualButtonBehaviour>().enabled = true;
                    iconCollections[i].actionIcons[j].GetComponent<Renderer>().enabled = true;
                }
            } else {
                for (int j = 0; j < iconCollections[i].actionIcons.Length; j++) {
                    iconCollections[i].actionIcons[j].GetComponent<VirtualButtonBehaviour>().enabled = false;
                    iconCollections[i].actionIcons[j].GetComponent<Renderer>().enabled = false;
                }
            }
        }
    }

    public void PromptIconCollectionSwap(int index) {
        SwapIconCollection(index);
    }
}
