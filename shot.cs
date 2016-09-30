//弾幕の挙動

using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour {
    //弾の追跡用
    GameObject sphere;

	// Use this for initialization
	void Start () {
        //初速
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //物に当たっても消えないようにするためにOnTriggerを使用
    void OnTriggerEnter(Collider other)
    {
        //自機に当たった時玉を消滅させて残機を減らす
        if (other.gameObject.CompareTag("me"))
        {
            Destroy(this.gameObject);
            sphere = GameObject.Find("Sphere(Clone)");
            if (sphere != null)
            {
                Destroy(sphere);
                GameObject.Find("sinkou(Clone)").GetComponent<sinkou>().zanki -= 1;
            }
        }
        //下まで行ったら自身を消去
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }
}