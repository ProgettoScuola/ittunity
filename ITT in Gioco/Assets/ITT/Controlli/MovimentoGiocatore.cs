using UnityEngine;
using System;
using ITT.Controlli;
using UnityStandardAssets.CrossPlatformInput;

public class MovimentoGiocatore : MonoBehaviour
{
    public float velocita = 7f;

    [Range(0, 1f)]
    public float accelerazione = 0.2f;
    public Transform camera;
    public float sensibilita = 3f;
    public float forzaSalto = 10f;
    public bool gravitaPersonalizzata = false;
    public float gravita = 30f;
    public bool abilitaGyroSeDisponibile = false;
    

    private ControlloMovimento controllo;
    private Rigidbody bodyGiocatore;

    private void Start()
    {
        controllo = new ControlloMovimento();
        bodyGiocatore = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        float inputOrizzontale = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        float inputVerticale = CrossPlatformInputManager.GetAxisRaw("Vertical");

        controllo.Movimento(bodyGiocatore, velocita, inputOrizzontale, inputVerticale, accelerazione);

        float mouseX = CrossPlatformInputManager.GetAxis("Mouse X");
        float mouseY = CrossPlatformInputManager.GetAxis("Mouse Y");

        mouseX *= sensibilita;
        mouseY *= sensibilita;

        controllo.RotazioneCamera(camera, transform, mouseX, mouseY, abilitaGyroSeDisponibile);

        if (CrossPlatformInputManager.GetButton("Jump"))
        {
            controllo.Salto(bodyGiocatore, forzaSalto);
        }

        if (gravitaPersonalizzata)
        {
            controllo.ApplicaGravitaPersonalizzata(bodyGiocatore, gravita);
        }
    }
}
