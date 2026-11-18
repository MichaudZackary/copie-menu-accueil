using UnityEngine;
using UnityEngine.UI;

public class GestionnaireUI : MonoBehaviour
{
    public Button btnJouer;
    public Button btnQuitter;
void Start()
    {
        // assigner un event listener au clic sur les bouton Jouer et Quitter
        btnJouer.onClick.AddListener(btnJouer_onClick);
        btnQuitter.onClick.AddListener(btnQuitter_onClick);


    }

    void btnJouer_onClick() 
    {
        // Message dans la console qui "lance la partie"
        Debug.Log("La partie commence ... (Bouton Jouer) ");
    }



    void btnQuitter_onClick() 
    {
        // Message dans la console qui "ferme le jeu"
        Debug.Log("Le partie ce ferme (Bouton Quitter)");
    }
}
