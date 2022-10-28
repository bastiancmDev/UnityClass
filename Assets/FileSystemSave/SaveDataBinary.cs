using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveDataBinary
{
    public static void SaveData(PlayerStats player)
    {
        
        BinaryFormatter formatter = new BinaryFormatter(); // Permite pasar los datos a binario para ser guardados mediante el sistema de Archivos

        string path = Application.persistentDataPath + "/playerInfo.data";  // Devuelve un path/ ruta que va a ser legible desde cualquier plataforma y será donde se guarde el archivo

        Debug.Log(path);

        FileStream stream = new FileStream(path, FileMode.Create); // Abre un fileStream y permite el acceso al disco para leer/escribir o modificar info.

        formatter.Serialize(stream, player); // Finalmete, convierte a binario, y guarda el archivo.

        stream.Close(); // Cierra la conexion y indica que el canal de lectura o escritura sea finalizado. 

    }

    public static PlayerStats LoadData()
    {
        try
        {
            string path = Application.persistentDataPath + "/playerInfo.data";

            if (File.Exists(path))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(); // // Permite pasar de un binario en un archivo a un objeto en el codigo

                FileStream fileStream = new FileStream(path, FileMode.Open); // Abre un fileStream y permite el acceso al disco para leer/escribir o modificar info.

                PlayerStats playerToReturn = binaryFormatter.Deserialize(fileStream) as PlayerStats; // Con el metodo Deserialize hacemos la convercion de binario a Object y con el "as" se setea el tipo de dato

                fileStream.Close();  // Cierra la conexion y indica que el canal de lectura o escritura sea finalizado.  

                return playerToReturn; // retornamos el tipo de dato ya leido

            }
            else
            {
                Debug.LogError("Directorio no encontrado");
                return null;
            }
        }catch(Exception e)
        {
            //Debug.LogError(" Ocurrio un error " + e.Message);
            return null;
        }

    }


}

[System.Serializable]
public class PlayerStats
{


    public string nameOfPlayer;
    public int coins;
    public int lifes;

    public PlayerStats(string name,int coins, int lifes)
    {
        this.nameOfPlayer = name;
        this.coins = coins;
        this.lifes = lifes;
    }
}
