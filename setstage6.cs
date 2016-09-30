//ステージ6のセット

using UnityEngine;
using System.Collections;

public class setstage6 : MonoBehaviour {
    //blockのプレハブを作成
    public GameObject block;
    public GameObject hardblock;
    //blockのカウント用
    GameObject obj;
    //sinkou.csにステージ6の情報を書き込むため
    sinkou stage6;
    //初期残機
    int zanki;
    //位置座標用
    new Vector3 position = new Vector3(0, 0, 0);

	// Use this for initialization
	void Start () {
        //残機を書き込むための準備
        stage6 = GameObject.Find("sinkou(Clone)").GetComponent<sinkou>();
        //残機設定
        zanki = 10;
        stage6.zanki = zanki;
        //ブロックの配置
        //通常タイプ
        for (int x = 13; x >= -13; x -= 2)
        {
            for (int z = 7; z >= 0; z -= 2)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(block, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        for (int x = 12; x >= -12; x -= 2)
        {
            for (int z = 6; z >= 0; z -= 2)
            {
                position = new Vector3(x, position.y, z);
                obj = (GameObject)Instantiate(hardblock, position, Quaternion.identity);
                obj.transform.parent = transform;
            }
        }
        //ゲームオーバー時のリトライ用にこのシーンを設定
        GameObject.Find("gameover").GetComponent<gameover>().retry = "scene6";
        //ゲームクリア時のリトライ用にこのシーンを設定
        GameObject.Find("gameclear").GetComponent<gameclear>().retry = "scene6";
	}
	
	// Update is called once per frame
	void Update () {
        //残りブロックのカウント
        stage6.count = transform.GetChildCount();
	}
}
