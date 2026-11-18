using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GestionnaireReglage : MonoBehaviour
{
    public GameObject menuReglage;
    public Button btnQuitterReglage;
    public Button btnReglage;
    public Slider sldVolume;
    public TMP_InputField ipfNomJoueur;
    public TMP_Dropdown ddChoixBatiment;
    public Toggle tglVsync;

    void Start()
    {
        // Cache le menu des réglages au départ
        menuReglage.SetActive(false);

        // assigne les event listener aux divers control
            // Boutton Quitter
        btnQuitterReglage.onClick.AddListener(btnQuitterReglage_onClick);
            // Boutton Reglage
        btnReglage.onClick.AddListener(btnReglage_onClick);
            // Slider Volume
        sldVolume.onValueChanged.AddListener(sldVolume_valueChanged);
            // inputfield Nom du joueur
        ipfNomJoueur.onSubmit.AddListener(ipfNomJoueur_valueChanged);
            // DropDown Batiment
        ddChoixBatiment.onValueChanged.AddListener(ddChoixBatiment_valueChanged);
            // togle Vsync
        tglVsync.onValueChanged.AddListener(tglVsync_onValueChanged);
    }   

    void btnQuitterReglage_onClick()
    {
        // ferme le menu des réglages
        menuReglage.SetActive(false);
    }
    void btnReglage_onClick()
    {
        // Ouvre le menu des réglages
        menuReglage.SetActive(true);
    }
    void sldVolume_valueChanged(float pourcentage)
    {
        // Message dans la console affiche le pourcentage du volume
        Debug.Log($"Le volume est à {pourcentage}%");
    }
    void ipfNomJoueur_valueChanged(string nomDuJoueur)
    {
        // Message dans la console affiche le nom du joueur
        Debug.Log($"Le nom du joueur est : {nomDuJoueur}");
    }

    void ddChoixBatiment_valueChanged(int choix)
    {
        // Message dans la console affiche le batiment selectionné
        Debug.Log($"Batiment selectione : {ddChoixBatiment.options[choix].text}");
    }

    void tglVsync_onValueChanged(bool val)
    {
        // Message qui affiche si le Vsync est activé
        Debug.Log($"Vsync : {val}");
    }



}
