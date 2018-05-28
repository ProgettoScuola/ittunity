using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Analogico : MonoBehaviour
{
    public float limiteDistanza = 100f;

    private Vector2 posizioneIniziale;
    private RectTransform rTransform;

    private void Start()
    {
        rTransform = GetComponent<RectTransform>();
        posizioneIniziale = rTransform.position;
    }

    private void Update()
    {
        rTransform.position = new Vector2(Mathf.Clamp(rTransform.position.x, posizioneIniziale.x - limiteDistanza, posizioneIniziale.x + limiteDistanza), Mathf.Clamp(rTransform.position.y, posizioneIniziale.y - limiteDistanza, posizioneIniziale.y + limiteDistanza));

        Vector2 deltaPosizione = (Vector2)rTransform.position - posizioneIniziale;

        CrossPlatformInputManager.SetAxis("Horizontal", deltaPosizione.x);
        CrossPlatformInputManager.SetAxis("Vertical", deltaPosizione.y);
    }

    private void OnMouseDrag()
    {
        Vector2 transformFinale = rTransform.position;

        transformFinale += (new Vector2(CrossPlatformInputManager.GetAxis("Mouse X"), CrossPlatformInputManager.GetAxis("Mouse Y"))/limiteDistanza).normalized;

        rTransform.position = transformFinale;
    }

    private void OnMouseUp()
    {
        rTransform.position = posizioneIniziale;
    }
}
