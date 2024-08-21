using UnityEngine;
using Puerts;
using System;
using System.Collections;

namespace UnityTSGame
{
    public delegate void ModuleInit(TSBehaviour monoBehaviour);

    //只是演示纯用js实现MonoBehaviour逻辑的可能，
    //但从性能角度这并不是最佳实践，会导致过多的跨语言调用
    public class TSBehaviour : MonoBehaviour
    {
        //可配置加载的js模块
        public string ModuleName;

        public Action TsStart;
        public Action TsUpdate;
        public Action TsOnDestroy;
        public Action<Collision> TsOnCollisionEnter;
        public Action<Collision> TsOnCollisionStay;
        public Action<Collision> TsOnCollisionExit;
        public Action<Collider> TsOnTriggerEnter;
        public Action<Collider> TsOnTriggerStay;
        public Action<Collider> TsOnTriggerExit;
        public Action<Animator, AnimatorStateInfo, int> TsOnStateEnter;
        public Action<Animator, AnimatorStateInfo, int> TsOnStateUpdate;
        public Action<Animator, AnimatorStateInfo, int> TsOnStateExit;
        public Action<Animator, AnimatorStateInfo, int> TsOnStateMove;
        public Action<Animator, AnimatorStateInfo, int> TsOnStateIK;
        public Action<string> TsOnAnimatorEvent;

        public IEnumerator Coroutine()
        {
            yield return new WaitForSeconds(1);
            Debug.Log("[JSManager] -  Coroutine done");
        }

        public void TSAnimatorEvent(string param)
        {
            if (TsOnAnimatorEvent != null) TsOnAnimatorEvent(param);
        }

        private void OnEnable()
        {
            var varname = "m_" + Time.frameCount;
            if(ModuleName == null || ModuleName == "") {
                UnityEngine.Debug.LogError("[TSBehaviour] - OnEnable init Module Failed -->" + ModuleName + "  " + this.gameObject.name);
            }

            var init = JSManager.GetJSEnv().Eval<ModuleInit>(ModuleName + ".init;");
            if (init != null) init(this);
        }

        private void OnDisable()
        {
            if (!JSManager.JSEnvDisposed() && TsOnDestroy != null) TsOnDestroy();
        }

        void Start()
        {
            if (TsStart != null) TsStart();
        }

        void Update()
        {
            if (TsUpdate != null) TsUpdate();
        }

        void OnDestroy()
        {
            TsStart = null;
            TsUpdate = null;
            TsOnDestroy = null;
        }

        void OnCollisionEnter(Collision other) {
            if (TsOnCollisionEnter != null) TsOnCollisionEnter(other);
        }

        void OnCollisionStay(Collision other) {
            if (TsOnCollisionStay != null) TsOnCollisionStay(other);
        }

        void OnCollisionExit(Collision other) {
            if (TsOnCollisionExit != null) TsOnCollisionExit(other);
        }

        void OnTriggerEnter(Collider other) {
            if (TsOnTriggerEnter != null) TsOnTriggerEnter(other);
        }

        void OnTriggerStay(Collider other) {
            if (TsOnTriggerStay != null) TsOnTriggerStay(other);
        }

        void OnTriggerExit(Collider other) {
            if (TsOnTriggerExit != null) TsOnTriggerExit(other);
        }

        void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (TsOnStateEnter != null) TsOnStateEnter(animator, stateInfo, layerIndex);
        }

        void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (TsOnStateUpdate != null) TsOnStateUpdate(animator, stateInfo, layerIndex);
        }

        void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (TsOnStateExit != null) TsOnStateExit(animator, stateInfo, layerIndex);
        }

        void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (TsOnStateMove != null) TsOnStateMove(animator, stateInfo, layerIndex);
        }

        void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            if (TsOnStateIK != null) TsOnStateIK(animator, stateInfo, layerIndex);
        }
    }
}