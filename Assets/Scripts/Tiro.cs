using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    private Vector3 direcao;
    public float velocidade = 4f;
    public int damage = 1;
   // private float timer = 2f;

    // Start is called before the first frame update
    void Start() {
        Vector3 player = GameObject.FindGameObjectWithTag("Zombie").transform.position;
        direcao = (player - transform.position).normalized;
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(direcao * velocidade * Time.deltaTime);
    }

    /*void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Zombie") {
            other.gameObject.GetComponent<Zombie>().levaTiro(damage);
           Destroy(other.gameObject);
        }
    }*/

 public GameObject prefab;

   void Metodo() {
    //instancia objeto com suas posições e rotações do prefab
    Instantiate(prefab); 

    //instancia um objeto com a posição e rotação original do objeto que o está instancionando
    Instantiate(prefab, transform.position, Quaternion.identity);

    //Recuperando o objeto instanciado
    GameObject obj = Instantiate(prefab);
}
}
