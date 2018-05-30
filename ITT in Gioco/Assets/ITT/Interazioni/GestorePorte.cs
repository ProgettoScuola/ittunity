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

        /**
         * Metodo che controlla se posso aprire o meno UnOggetto di tipo PORTA
         * Prende la porta con cui si interagisce e controlla nel inventario se si possiede la chiave ee se necessaria
         * 
         * Return true se si puo aprire, false se non si puo aprire
         * */
        public Boolean ControllaPorta(OggettoDiInterazione ogg,Inventario i)
        {
            if(ogg.Tipologia != OggettoDiInterazione.TipologiaOgettoDiInterazione.PORTA)
            {
                return false;
            }

            if (!ogg.accessibile)
            {
                return true;
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