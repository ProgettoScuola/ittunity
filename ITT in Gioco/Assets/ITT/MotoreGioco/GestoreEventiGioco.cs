using UnityEngine;
using UnityEngine.UI;

public class GestoreEventiGioco : MonoBehaviour
{
    public static GestoreEventiGioco gestoreEventiGioco;

    private void Start()
    {
        if(gestoreEventiGioco == null)
        {
            gestoreEventiGioco = this;
        }
        else if(gestoreEventiGioco != this)
        {
            Destroy(gameObject);
        }
    }

    public void CambiaInput(bool toggle)
    {
        FindObjectOfType<MovimentoGiocatore>().abilitaGyroSeDisponibile = toggle;
    }
    public void Slider()
    {
        gameObject.SetActive(true);
    }
    public static void DebugLine(string oggetto)
    {
        Text debugLine = GameObject.FindGameObjectWithTag("debugLine").GetComponent<Text>();
        debugLine.text = oggetto;
    }
}
