//ゲームクリア時の処理

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameclear : MonoBehaviour {
    //クリアフラグ管理
    public bool flag;
    //玉消し用
    GameObject sphere;
    //リトライ時の再読み込み用
    public string retry;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        //ゲームクリアフラグが立っている時リトライボタンとタイトルボタンの表示
        if (flag == true)
        {
            //残ってる玉を消去
            sphere = GameObject.Find("Sphere(Clone)");
            if (sphere != null)
            {
                Destroy(sphere.gameObject);
            }
            //おめでとうの表示、リトライ、タイトルボタンの表示
            this.GetComponent<Text>().text = string.Format("Congratulation");
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
