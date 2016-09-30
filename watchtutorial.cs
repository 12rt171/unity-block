//チュートリアルを再生するかどうか選択

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class watchtutorial : MonoBehaviour
{
    //一時作業用変数
    GameObject temp;
    //どのボタンを押してもいい、という意思表示
    public GameObject pressanykey;
    //チュートリアル
    public GameObject tutorial;
    //チュートリアルを載せるキャンバスの取得
    public GameObject canvas;
    //チュートリアルを見ない場合本編再生
    public GameObject setstage;
    public GameObject sinkou;
    // Use this for initialization
    void Start()
    {
        //チュートリアルを見るかどうか確認
        this.gameObject.GetComponent<Text>().text = "チュートリアルを見ますか？";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        //見る場合
        if (GUI.Button(new Rect(350, 400, 300, 40), "yes"))
        {
            temp = Instantiate(pressanykey, new Vector3(40, -340, 0), Quaternion.identity) as GameObject;
            temp.transform.SetParent(canvas.transform, false);
            temp = Instantiate(tutorial, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            temp.transform.SetParent(canvas.transform, false);
            Destroy(this.gameObject);
        }
        //見ない場合
        if (GUI.Button(new Rect(350, 480, 300, 40), "no"))
        {
            temp = Instantiate(setstage, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            temp.transform.SetParent(canvas.transform, false);
            Instantiate(sinkou, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
