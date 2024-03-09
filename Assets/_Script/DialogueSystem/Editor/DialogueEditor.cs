using UnityEditor;

namespace Dialogue.Editor
{
    public class DialogueEditor : EditorWindow
    {
        [MenuItem("Window/Dialogue Editor")]
        public static void ShowEditorWindow()
        {
            //* When click the Dialogue Editor to pop up the window
            GetWindow(typeof(DialogueEditor), false, "Dialogue Editor");


        }
    }
}
