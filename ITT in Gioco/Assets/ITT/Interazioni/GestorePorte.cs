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
    public class GestorePorte
    {

        /// <summary>
        /// controlla se la porta è accessibile e se serve l'accesso o no,se accessibile e serve l'accesso, ricerca 
        /// la chiave all'interno dell'inventario e se a disposizione viene utilizzata e rimossa.
        /// </summary>
        /// <param name="ogg">oggetto con cui si va ad interagire</param>
        /// <param name="i"> inventario dell'utente </param>
        /// <returns>ritorna false se non è possibile aprirla altrimenti true.</returns>
        public Boolean ControllaPorta(OggettoDiInterazione ogg,Inventario i)
        {
            if(ogg.Tipologia != OggettoDiInterazione.TipologiaOgettoDiInterazione.PORTA)
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
                //controllo nell'inventario se ho la chiave
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