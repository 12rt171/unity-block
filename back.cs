//backボタンを押した時の挙動

using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonPush() {

        //title sceneへ戻る
        Application.LoadLevel("title");
 	
    } 

}
