using UnityEngine;

using System.IO;
using System;

namespace ITT.Salvataggio.Statistiche
{
    public class Statistiche : MonoBehaviour
    {
        public Statistiche()
        {
            //init
        }

        const bool DEBUG_ON = true;

        PlayerInfo stats = new PlayerInfo();

        string filepath = "stats_saved.json";
        string id_obj_gui = "Cube";

        public void Start() //metodo per interfacciarsi con la parte grafica, puo essere sostituito con qualsiasi altro evento
        {
            //metodo load
            load(id_obj_gui);
        }

        public void OnMouseEnter() //metodo per interfacciarsi con la parte grafica, puo essere sostituito con qualsiasi altro evento
        {
            //metodo save
            save(id_obj_gui);
        }

        public void load(string id)
        {
            //controllo sul file, se non esiste lo crea
            if (!File.Exists(filepath))
            {
                try
                {
                    Debug.Log("il file non esiste, lo creo");
                    File.Create(filepath);
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
            }
            else
            {
                stats = new PlayerInfo();
                stats = ReadFromFile(filepath);
                //load effettivo
                setPosition(stats.position, id);
                setRotation(stats.rotation, id);
            }
        }

        public void save(string id)
        {
            //get all variables from the gamne
            stats.position = getPosition(id);
            stats.rotation = getRotation(id);
            stats.salute = 12; //variabile di prova
            stats.fame = 12; //variabile di prova
            //save effettivo
            WriteToFile(filepath);
        }

        //write to file, posso utilizzare questo metodo per leggere direttamente l'istanza della classe
        public void WriteToFile(string filePath)
        {
            // Convert the instance ('this') of this class to a JSON string with "pretty print" (nice indenting).

            string json = JsonUtility.ToJson(stats, true);

            // Write that JSON string to the specified file.
            File.WriteAllText(filePath, json);

            // Tell us what we just wrote if DEBUG_ON is on.
            if (DEBUG_ON)
                Debug.LogFormat("WriteToFile({0}) -- data:\n{1}", filePath, json);
        }

        //read dal file
        public PlayerInfo ReadFromFile(string filePath)
        {
            // If the file does exist then read the entire file to a string.
            string contents = File.ReadAllText(filePath);

            // If debug is on then tell us the file we read and its contents.
            if (DEBUG_ON)
                Debug.LogFormat("ReadFromFile({0})\ncontents:\n{1}", filePath, contents);

            // If it happens that the file is somehow empty then tell us and return a new SaveData object.
            if (string.IsNullOrEmpty(contents))
            {
                Debug.LogErrorFormat("File: '{0}' is empty. Returning default SaveData");
                return new PlayerInfo();
            }

            // Otherwise we can just use JsonUtility to convert the string to a new SaveData object.
            return JsonUtility.FromJson<PlayerInfo>(contents);
        }

        //getter to save the data

        //get position of target element
        public Vector3 getPosition(string id)
        {
            return GameObject.Find(id).transform.position;
        }

        //get rotation of target element
        public Quaternion getRotation(string id)
        {
            return GameObject.Find(id).transform.rotation;
        }


        //setter to laod the data

        //set position of target element
        public void setPosition(Vector3 pos, string id)
        {
            GameObject.Find(id).transform.position = pos;
        }

        //set rotation of target element
        public void setRotation(Quaternion rot, string id)
        {
            GameObject.Find(id).transform.rotation = rot;
        }
    }
}