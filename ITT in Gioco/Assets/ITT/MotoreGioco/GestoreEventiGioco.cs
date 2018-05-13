using UnityEngine;
using UnityEngine.UI;

public class GestoreEventiGioco : MonoBehaviour
{
    public void CambiaInput(bool toggle)
    {
        FindObjectOfType<MovimentoGiocatore>().abilitaGyroSeDisponibile = toggle;
    }
}
