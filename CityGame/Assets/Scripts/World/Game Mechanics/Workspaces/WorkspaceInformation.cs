using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WorkspaceInformation : ISerialize
{
    [SerializeField] private Characters head;
    [SerializeField] private Characters assistant;

    [SerializeField] private List<CityProjectSpaceRefrence> projectQueue;


    public void CopyFrom(ISerialize incomingClass)
    {
        var tempClass = incomingClass as WorkspaceInformation;
        Head = tempClass.Head;
        assistant = tempClass.Assistant;
        projectQueue = tempClass.projectQueue;
    }

    public void DeserializeInformation(PathAndFileName pathAndFileName)
    {
        var deserializedClass = ClassSerializer.DeserializeClass(this, pathAndFileName);
        CopyFrom(deserializedClass);
    }

    public void SerializeInformation(PathAndFileName pathAndFileName)
    {
        ClassSerializer.SerializeClass(this, pathAndFileName);
    }
    public Characters Head { get => head; set => head = value; }
    public Characters Assistant { get => assistant; set => assistant = value; }
    public List<CityProjectSpaceRefrence> ProjectQueue { get => projectQueue; set => projectQueue = value; }
}

