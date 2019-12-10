using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEditor;

public class ScoreReader : MonoBehaviour
{
    public Text fileContents;

    public void Start()
    {
        Read();
        
    }
    public void Read()
    {
        string path = "Assets/scores.txt";
        string lineRead = "";
        fileContents.text = "";
        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            lineRead = reader.ReadLine();
            Debug.Log(lineRead);
            fileContents.text += lineRead + "\n";
        }
        reader.Close();


    }

    public InputField writeToFile;

    public void Write()
    {
        string path = "Assets/scores.txt";
        string Player = writeToFile.text;

        
        if (File.Exists(path))
        {
            string[] createText = {Player };
            File.WriteAllLines(path, createText);
        }
        else
        {
            Debug.Log("File does not exist");
        }

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("test");
    }
}
