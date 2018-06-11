using System.Collections.Generic;

namespace ITT.MotoreGioco
{

    public class Inventario
    {


        public float maxPeso = 50f;
        public List<OggettoInventario> listaOggettiInventario;


        public Inventario()
        {
            listaOggettiInventario = new List<OggettoInventario>();
        }
        /// <summary>
        /// Rimuove l'oggetto utilizzato dall'inventario utente
        /// </summary>
        /// <param name="o">oggetto che verrà rimosso</param>
        /// <returns> true l'oggetto viene rimosso false se non è stato trovato l'oggetto nell'inventario </returns>
        public bool rimuoviOggettoInventario(OggettoInventario o)
        {
           return listaOggettiInventario.Remove(o);
        }

        /// <summary>
        /// Cerca un oggetto all'interno dell'inventario attraverso l'ID.
        /// </summary>
        /// <param name="id">Valore identificativo dell'oggetto dell'inventario</param>
        /// <returns>ritorna oggetto se l'oggetto è stato trovato, ritorna null se l'oggetto non è stato trovato</returns>
        public OggettoInventario cercaIdOggetto (int id)
        {
            foreach (OggettoInventario o in listaOggettiInventario)
            {
                if(id == o.id)
                {
                    return o;
                }
            }
            return null;//ritorna valore null se non trova l'id ricercato.
        }

        /// <summary>
        /// ricerca un oggetto all'interno dell'inventario attraverso la loro tipologia. se presenti più oggetti
        /// della stessa tipologia all'interno dell'inventario, ritorna il primo oggetto trovato.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public OggettoInventario cercaOggettoPerTipologia(OggettoInventario.TipologiaOggettoInventario e)
        {
            foreach (OggettoInventario o in listaOggettiInventario)
            {
                if (o.Tipologia == e)
                {
                    return o;
                }
            }
            return null;//ritorna valore null se non trova l'id ricercato.
        }


        /// <summary>
        /// Aggiunge un oggetto all'interno dell'inventario controllando se è stato superato il limite massimo del peso, controlla
        /// nel caso sia possibile inserirlo se è un oggetto accumulabile(quantità + 1)oppure no.
        /// </summary>
        /// <param name="o">oggetto da aggiungere all'inventario</param>
        /// <returns>ritorna l'oggetto appena aggiunto o quello modificato dalle quantità oppure ritorna null se il peso massimo dell'inventario è stato superato 
        /// e l'oggetto non è stato aggiunto</returns>
        public OggettoInventario aggiungiOggetto(OggettoInventario o)
        {
            if(getSommmaPesiOggettiInventario() + o.peso  < maxPeso) {
                if(o.Tipologia == OggettoInventario.TipologiaOggettoInventario.MONETE
                    || o.Tipologia == OggettoInventario.TipologiaOggettoInventario.BATTERIE
                    || o.Tipologia == OggettoInventario.TipologiaOggettoInventario.CIBO
                    || o.Tipologia == OggettoInventario.TipologiaOggettoInventario.FIALETTE
                    )
                {
                    OggettoInventario f = cercaOggettoPerTipologia(o.Tipologia);
                    if (f != null)
                    {
                        //trovato
                        f.quantita += o.quantita;
                        return f;
                    }
                    else
                    {
                        listaOggettiInventario.Add(o);
                        return o;
                    }
                }
                else
                {
                    listaOggettiInventario.Add(o);
                    return o;
                }
                
            }
            else
            {
                return null;//torna valore null perche ha raggiunto il peso massimo.
            }
            
        }

        /// <summary>
        /// calcola la somma dei pesi nell'inventario
        /// </summary>
        /// <returns>un float rappresentante il peso attuale dell'inventario.</returns>
        public float getSommmaPesiOggettiInventario()
        {
            float somma = 0f;
            foreach(OggettoInventario o in listaOggettiInventario)
            {
                somma = somma + o.peso;
            }
            return somma;
        }
    }
}