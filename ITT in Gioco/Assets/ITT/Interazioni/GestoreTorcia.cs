using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System.Collections;
using ITT.MotoreGioco;
using System.Timers;


/**
 Classe per l'interazioni con la torcia
 * */
namespace ITT.Interazione
{
    public class GestoreTorcia
    {
        private Timer timer;
        private Inventario inventario;




        /// <summary>
        /// Costruttore Gestore torcia.
        /// </summary>
        /// <param name="i">Inventario dell'utente.</param>
        public GestoreTorcia(Inventario i)
        {
            inventario = i;
            timer = new Timer(3000);
            timer.Elapsed += Timer_Elapsed;
            OggettoInventario torcia = this.inventario.cercaOggettoPerTipologia(OggettoInventario.TipologiaOggettoInventario.TORCIA);
            if (torcia != null)
            {
                this.timer.Start();
            }
        }
        /// <summary>
        /// Tick del timer ogni 3 sec
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OggettoInventario torcia = this.inventario.cercaOggettoPerTipologia(OggettoInventario.TipologiaOggettoInventario.TORCIA);
            if (torcia != null)
            {
                torcia.carica--;
                if (torcia.carica<=0)
                {
                    this.timer.Stop();
                }
            }
        }
        /// <summary>
        /// Controlla se la torcia è utilizzabile,quindi se è carica.
        /// </summary>
        /// <param name="ogg">Oggetto di inventario torcia</param>
        /// <returns>true se utilizzabile altrimenti false.</returns>
        public Boolean ControllaTorcia(OggettoInventario ogg)
        {
            if (ogg.Tipologia != OggettoInventario.TipologiaOggettoInventario.TORCIA)
            {
                return false;
            }

            if (ogg.carica==0)
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// Controllo se ho batterie nell'inventario, se si scalo la quantità di 1 e cerco la torcia nell'inventario e la ricarico.
        /// </summary>
        /// <returns>Ritorna false se non trova le batterie nell'inventario, altrimenti true.</returns>
        public Boolean CambiaBatteriaTorcia()
        {
            OggettoInventario batterie = this.inventario.cercaOggettoPerTipologia(OggettoInventario.TipologiaOggettoInventario.BATTERIE);
            if(batterie==null || batterie.quantita==0 )
            {
                return false;
            }
            else
            {
                batterie.quantita--;
                OggettoInventario torcia = this.inventario.cercaOggettoPerTipologia(OggettoInventario.TipologiaOggettoInventario.TORCIA);
                torcia.carica = 100;
                this.timer.Start();
                return true;
            }
        }

    }
}