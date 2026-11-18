using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progressbar : MonoBehaviour
{
    public Transform cam;
    public int numberofslides;
    float dif;
    void Update()
    {
        dif = cam.position.x /(numberofslides*20); 
        // dif *=dif;
        this.transform.localScale = new Vector3(36*dif,1,1);

        // Le numberofslides devrait être = au nombre de slides que le diapo à (horizontal) la mon scipt est fait pour les ecran en 16:9em dc le deplacement de la barre est irrégulier je pourrais le faire de maniere plus inteligente mais c'est baclé de bz comme produit :v
    }
}
