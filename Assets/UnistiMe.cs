using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnistiMe : MonoBehaviour {

    public int vrijemeUnistenja;

    void Start() {
        Destroy(gameObject, vrijemeUnistenja);
    }

    // Update is called once per frame
    void Update() {

    }
}
