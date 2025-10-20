using UnityEngine;

public enum Scareiness { NotSpooky, Spooky }
public enum Obviousness { NotObvious, Obvious }

public class Anomaly : ScriptableObject
{
    public string anomalyName;
    public GameObject prefab;
    public Scareiness scareiness; 
    public Obviousness obviousness;
    public bool hasBeenSeen = false;
}
