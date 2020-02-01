using UnityEngine;

using System.Collections;
using System.Collections.Generic;


namespace baseComponents
{
    public class BaseWorkbench : MonoBehaviour
    {
        private bool _occupied = false;
        public bool occupied
        {
            get { return _occupied; }
            set { _occupied = value; }
        }

        private int _processTime;
        public int processTime
        {
            get { return _processTime; }
            set { _processTime = value; }
        }
    }
}
