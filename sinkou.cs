//ゲーム全体の進行

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class sinkou : MonoBehaviour
{
    //残機表示
    public int zanki;
    //blockのカウント用
    public int count;
    //sphereのプレハブを作成
    public GameObject sphere;
    //sphereがすでに作成されているか調べるため
    GameObject clone;
    //自機の追跡用
    public GameObject cube;
    //3次元座標
    new Vector3 position = new Vector3(0,0,0);
    //ゲームオーバーフラグ管理
    public GameObject gameoverflag;
    //ゲームクリアフラグ管理
    public GameObject gameclearflag;

    // Use this for initialization
    void Start()
    {
        //自機の情報取得
        cube = GameObject.Find("Cube 5");
    }

    // Update is called once per frame
    void Update()
    {
        //残機が残っている時の処理
        if (zanki >= 0)
        {
            //Sphere(Clone)が作成されているか探す
            clone = GameObject.Find("Sphere(Clone)");
            if (clone == null)
            {
                //Sphere(Clone)が無い場合、spaceを押したらsphereを生成
                if (Input.GetKeyUp(KeyCode.Space))
                {
                    //自機の真上に生成
                    position = new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z + 1);
                    Instantiate(sphere, position, Quaternion.identity);
                }
            }
        }
        //残機が0でミスしたらゲームオーバー
        else if(zanki < 0) {
            GameObject.Find("gameover").GetComponent<gameover>().flag = true;
        }
        //ブロックが全部消えたらクリア
        if (count == 0) 
        {
            GameObject.Find("gameclear").GetComponent<gameclear>().flag = true;
        }
    }
    void OnGUI () {
        //残りblockの数の表示
        GUI.TextField(new Rect(10, 10, 150, 150),string.Format("残りブロック数:{0}\n残機:{1}",count.ToString(),zanki.ToString()));
 }
}
