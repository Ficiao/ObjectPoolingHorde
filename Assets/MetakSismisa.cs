using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetakSismisa : MonoBehaviour {

    private Igrac igracSkripta;
    private Vector2 ciljanaPozicija;
    public float brzina;
    public int steta;
    public GameObject efektUnistenja;

    // Start is called before the first frame update
    void Start() {
        igracSkripta = GameObject.FindGameObjectWithTag("Igrac").GetComponent<Igrac>();
        ciljanaPozicija = igracSkripta.transform.position;
    }

    // Update is called once per frame
    void Update() {

    }
}
