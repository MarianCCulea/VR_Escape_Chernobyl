using System;
using System.Collections;
using System.Linq;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace GameFiles.Scripts
{
    public class SwitchList : MonoBehaviour
    {
        private bool[] list={ false,true,true,false,false,false,true,true,true,false,true,false,true,false };
        private bool[] answer=new bool[] { false,false,true,false,true,false,false,true,false,true,true,true,false,true };
        private ArrayList lista = new ArrayList();
        [SerializeField] private UnityEvent switchAnswered;

        public void ChangePosition(int pos, bool value)
        {
            list[pos] = value;
            AnswerCheck();
        }

        public void AnswerCheck()
        {
            if (list.SequenceEqual(answer))
            {
                switchAnswered.Invoke();
            }
            else
            {
                //bad
            }
        }
        
    }
}