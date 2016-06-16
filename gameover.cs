//ゲームオーバー時処理

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameover : MonoBehaviour {
    //ゲームオーバーフラグ
    public bool flag;
    //リトライ時の再読み込み用
    public string retry;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnGUI() {
        //ゲームオーバーフラグが立っている時リトライボタンとタイトルボタンの表示
        if (flag == true)
        {
            this.GetComponent<Text>().text = string.Format("Game Over");
            if (GUI.Button(new Rect(350, 400, 300, 40), "retry"))
            {
                Application.LoadLevel(retry);
            }
            if (GUI.Button(new Rect(350, 480, 300, 40), "title"))
            {
                Application.LoadLevel("title");
            }
        }
    }
}
