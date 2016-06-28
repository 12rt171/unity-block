using UnityEngine;
using System.Collections;

public class warpC : MonoBehaviour {
    public bool flag;

	// Use this for initialization
	void Start () {
        flag = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("sphere"))
        {
            if (flag == false)
            {

                GameObject.Find("warp CC").GetComponent<warpCC>().flag = true;
                other.GetComponent<Transform>().position = new Vector3(-8, 0, 4);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
            if (flag == true)
            {
                flag = false;
            }
    }
}
