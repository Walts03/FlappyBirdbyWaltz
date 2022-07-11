using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LibraryHelper;
using LibraryHelper.Utils;

public class GameHandler : MonoBehaviour {

    private void Start() {
        Debug.Log("GameHandler.Start");
        Score.Start();
    }

}
