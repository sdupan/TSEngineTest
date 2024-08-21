using UnityEngine;
using UnityTSGame;
using System.Diagnostics;
using System.Security;

namespace UnityEditor.GUI
{
    [CustomEditor(typeof(TSBehaviour))]
    public class TSBehaviourEditor : Editor
    {
        private TSBehaviour _instance;

        void OnEnable()
        {
            _instance = target as TSBehaviour;
        }

        void OnDisable()
        {
            _instance = null;
        }

        public override void OnInspectorGUI()
        {
            if (_instance == null)
            {
                base.OnInspectorGUI();
                return;
            }

            this.DrawDefaultInspector();

            if(GUILayout.Button("Open TS Source File"))
            {
                UnityEngine.Debug.Log("Process.Start-->BEGIN");
                ProcessStartInfo start = new ProcessStartInfo("Code");
                start.Arguments = Application.dataPath + "/../TsProj/src/mono/" + _instance.ModuleName + ".ts";
                start.CreateNoWindow = false;
                start.ErrorDialog = false;
                start.UseShellExecute = true;
                start.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(start);
            }
        }
    }
}