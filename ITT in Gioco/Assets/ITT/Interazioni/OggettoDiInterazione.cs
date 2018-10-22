using UnityEngine;
using System.Collections;

public class OggettoDiInterazione : MonoBehaviour
{
    public int ID = 0;
    public bool accessibile = false;
    public bool serveAccesso = false;
  

    public enum TipologiaOgettoDiInterazione{ PORTA, COMPUTER, DISTRIBUTORE };

    public TipologiaOgettoDiInterazione Tipologia;


}
