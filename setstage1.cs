//ステージ1のセット

using UnityEngine;
using System.Collections;

public class setstage1 : MonoBehaviour {
    //blockのプレハブを作成
    public GameObject block;
    //blockのカウント用
    GameObject obj;
    //sinkou.csにステージ1の情報を書き込むため
    sinkou stage1;
    //初期残機
    int zanki;
    //位置座標用
    new Vector3 position = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
        //残機を書き込むための準備
        stage1 = GameObject.Find("sinkou(Clone)").GetComponent<sinkou>();
        //残機設定
        zanki = 3;
        stage1.zanki = zanki;
        //ブロックの配置
        //通常タイプ
        for (int x = 12; x >= -12; x -= 4)
        {
            for (int z = 6; z >= 0; z -= 4)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(block, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        for (int x = 10; x >= -10; x -= 4)
        {
            for (int z = 4; z >= 0; z -= 4)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(block, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        //ゲームオーバー時のリトライ用にこのシーンを設定
        GameObject.Find("gameover").GetComponent<gameover>().retry = "scene1";
        //ゲームクリア時のリトライ用にこのシーンを設定
        GameObject.Find("gameclear").GetComponent<gameclear>().retry = "scene1";
	}
	
	// Update is called once per frame
	void Update () {
        //残りブロックのカウント
        stage1.count = transform.GetChildCount();
	}
}
