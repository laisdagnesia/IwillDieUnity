using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoTiro : MonoBehaviour
{
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
