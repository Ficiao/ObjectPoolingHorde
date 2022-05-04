using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projektil : MonoBehaviour {

    public float brzina;
    public float vrijemeTrajanja;
    public GameObject eksplozija;
    public int steta;

    /*void Start() {
        Invoke("UnistavanjeProjektila", vrijemeTrajanja);
    }*/


    void Update() {
        transform.Translate(Vector2.up * brzina * Time.deltaTime);
    }

    void UnistavanjeProjektila() {
        Instantiate(eksplozija, transform.position, Quaternion.identity);
        Destroy(gameObject);
        //EnemyPool.Instance.DestroyBullet(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Igrac")
        {
            return;
        }

        if (collision.tag == "Neprijatelj")
        {
            collision.GetComponent<Neprijatelj>().PrimiStetu(steta);
        }

        UnistavanjeProjektila();        
    }
}
