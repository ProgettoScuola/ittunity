using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System.Collections;
using ITT.MotoreGioco;

/**
 classe per le interazioni con le porte
 * */
namespace ITT.Interazione
{
    public class GestoreComputer
    {



        /// <summary>
        /// controlla se è possibile accedere al computer e se necessita di un accesso,se è possibile accedere ed è richiesto l'accesso
        /// cerca l'oggetto password nell'inventario e se trovato lo utilizza e rimuove.
        /// </summary>
        /// <param name="ogg">oggetto di interazione</param>
        /// <param name="i"> inventario dell'utente</param>
        /// <returns>ritorna false se non è accessibile altrimenti torna true</returns>
        public Boolean ControllaComputer(OggettoDiInterazione ogg,Inventario i)
        {
            if (ogg.Tipologia != OggettoDiInterazione.TipologiaOgettoDiInterazione.COMPUTER)
            {
                return false;
            }

            if (!ogg.accessibile)
            {
                return false;
            }
            if (!ogg.serveAccesso)
            {
                return true;
            }
            else
            {
                //controllo nell'inventario se ho loggetto con la password ( postit)
                OggettoInventario o = i.cercaIdOggetto(ogg.ID);
                if ( o == null)
                {
                    return false;//non posso aprire la porta perchè manca la chiave.    
                }
                else
                {
                    i.rimuoviOggettoInventario(o);
                    return true;//se trova l'oggetto lo rimuove e passa il valore true.
                }

                


            }
            return false;
        }
    }
}