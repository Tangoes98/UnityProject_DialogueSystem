using UnityEngine;

namespace Dialogue
{

    [CreateAssetMenu(fileName = "New Dialogue", menuName = "ScriptableObjcet/Dialogue", order = 0)]
    public class SO_Dialogue : ScriptableObject
    {
        [SerializeField] DialogueNode[] dialogueNodes;
    }
}
