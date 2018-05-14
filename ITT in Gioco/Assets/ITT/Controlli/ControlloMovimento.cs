using System;
using UnityEngine;

namespace ITT.Controlli
{
    class ControlloMovimento
    {
        public void Movimento(Rigidbody bodyGiocatore, float velocita, float inputOrizontale, float inputVerticale, float accelerazione)
        {
            Vector3 movimento;
            Vector3 velocitaOrizzontale;
            Vector3 velocitaVerticale;

            velocitaOrizzontale = (bodyGiocatore.transform.right * inputOrizontale);
            velocitaVerticale = (bodyGiocatore.transform.forward * inputVerticale);

            movimento = (velocitaOrizzontale + velocitaVerticale).normalized * velocita;

            movimento.y = bodyGiocatore.velocity.y;

            bodyGiocatore.velocity = Vector3.Lerp(bodyGiocatore.velocity, movimento, 0.2f);
        }

        public void RotazioneCamera(Transform transformCamera, Transform transformGiocatore, float mouseX, float mouseY, bool abilitaGiroscopioSeDisponibile)
        {
            if (abilitaGiroscopioSeDisponibile && SystemInfo.supportsGyroscope)
            {
                Gyroscope gyro = Input.gyro;

                if (!gyro.enabled)
                {
                    gyro.enabled = true;
                }
                Vector3 rotazione_giocatore = transformGiocatore.rotation.eulerAngles;
                Vector3 rotazione_camera = transformCamera.rotation.eulerAngles;

                
                Quaternion rotazione = gyro.attitude;

                transformCamera.rotation = rotazione;
            }
            else
            {
                Vector3 rotazione1 = Vector3.up * mouseX;
                Vector3 rotazione2 = Vector3.right * -mouseY;

                transformGiocatore.Rotate(rotazione1);
                transformCamera.Rotate(rotazione2);
            }
        }

        public void Salto(Rigidbody bodyGiocatore, float forzaSalto)
        {
            if (ControllaAtterraggio(bodyGiocatore))
            {
                Vector3 velocitaGiocatore = bodyGiocatore.velocity;
                velocitaGiocatore.y += forzaSalto;

                bodyGiocatore.velocity = velocitaGiocatore;
            }
        }

        public void ApplicaGravitaPersonalizzata(Rigidbody bodyGiocatore, float gravita)
        {
            if (bodyGiocatore.useGravity)
            {
                bodyGiocatore.useGravity = false;
            }

            Vector3 gravitaGiocatore = new Vector3();

            gravitaGiocatore.y -= gravita;

            bodyGiocatore.AddForce(gravitaGiocatore);
        }

        private bool ControllaAtterraggio(Rigidbody bodyGiocatore)
        {
            Collider hitbox = bodyGiocatore.GetComponent<Collider>();

            float bordoHitbox = hitbox.bounds.extents.y;
            return Physics.Raycast(bodyGiocatore.position, -Vector3.up, bordoHitbox + 0.1f);
        }
    }
}
