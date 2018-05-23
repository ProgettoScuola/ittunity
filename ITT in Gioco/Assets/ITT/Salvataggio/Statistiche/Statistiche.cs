using UnityEngine;

using System.IO;
using System;

namespace ITT.Salvataggio.Statistiche
{
    class Statistiche
    {
        public Statistiche()
        {
            //init
        }

        const bool DEBUG_ON = true;

        PlayerInfo stats = new PlayerInfo();

        string filepath = "/salvataggio.json";

        public void Load(string id)
        {
            stats = new PlayerInfo();
            stats = ReadFromFile(filepath);

            setPosition(stats.position, id);
            setRotation(stats.rotation, id);
        }

        public void Save(string id)
        {
            //get all variables from the gamne
            stats.position = getPosition(id);
            stats.rotation = getRotation(id);
            stats.salute = 12;
            stats.fame = 12;
            //load effettivo
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
            // If the file doesn't exist then just return the default object.
            if (!File.Exists(filePath))
            {
                try
                {
                    Debug.Log("il file non esiste");
                    File.Create(filePath);
                    return new PlayerInfo();
                }
                catch (Exception e)
                {
                    Debug.Log(e);
                }
                return new PlayerInfo();
            }
            else
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