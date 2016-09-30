using UnityEngine;
using System.Collections;

public class hardblock : MonoBehaviour {
    //耐久値
    int hp;

	// Use this for initialization
	void Start () {
        //耐久値の設定
        hp = 2;
	}
	
	// Update is called once per frame
	void Update () {
        if (hp <= 0)
            Destroy(this.gameObject);
	}

    void OnCollisionExit(Collision other) {
        if (other.gameObject.CompareTag("sphere"))
        {
            hp -= 1;
            this.GetComponent<Renderer>().material.color = new Color(255,0,0);
        }
    }
}
