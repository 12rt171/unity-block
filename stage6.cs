//stage6ボタンを押した時の挙動

using UnityEngine;
using System.Collections;

public class stage6 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonPush()
    {
        //stage6 sceneへ飛ぶ
        Application.LoadLevel("scene6");

    } 

}
