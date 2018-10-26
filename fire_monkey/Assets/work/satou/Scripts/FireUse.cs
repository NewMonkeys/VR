using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireUse : MonoBehaviour {

    [SerializeField]
    private GameObject body;

    [SerializeField]
    private GameObject hose;

    [SerializeField]
    private GameObject map;

    // Use this for initialization
    void Start () {
        body.SetActive(false);
        hose.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        map.SetActive(false);
        body.SetActive(true);
        hose.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
