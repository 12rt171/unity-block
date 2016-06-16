//title  sceneでの挙動

using UnityEngine;
using System.Collections;

public class title : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() {
        //ステージ選択ボタンの表示
        if (GUI.Button(new Rect(350, 500, 300, 50), "start")) {
            Application.LoadLevel("stage");
        
        }
    
    }
}
