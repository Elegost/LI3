using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayText : MonoBehaviour {

    public string texte = "J'ai un gros zizi bien poilu";
    public float vitesseDefilement = 1f;

    private int avancementDefilement;
    private TextMesh zoneTexte;


    // Use this for initialization
    void Start () {
        avancementDefilement = 0;
        zoneTexte = GetComponent<TextMesh>();
        StartCoroutine(ExecuteApresDelai(1));
    }
	
	// Update is called once per frame
	/*void Update () {
        if(avancementDefilement < texte.Length)
            zoneTexte.color.a
        zoneTexte.text += gererDefilement();

	}*/

    void AffichageLettre(){

    }

    string gererDefilement()
    {
        if (avancementDefilement < texte.Length)
        {
            //TROUVER UN MOYEN DE FAIRE DEFILER TEXTE
            return texte[avancementDefilement++].ToString();
        }
        return "";
    }

    IEnumerator ExecuteApresDelai(float delai){
        while (true) { 
        yield return new WaitForSeconds(delai);
            if (avancementDefilement < texte.Length)
            {
                zoneTexte.text += gererDefilement();
            }
        }
    }
}
