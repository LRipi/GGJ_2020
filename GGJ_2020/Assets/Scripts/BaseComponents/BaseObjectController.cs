using System.ComponentModel;
using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace baseComponents {
  public class BaseObject : MonoBehaviour {

      private bool _taken = false;

      public bool taken
      {
        get { return _taken; }
        set { _taken = value; }
      }

      private bool _analyzed = false;
      
      public bool analyzed
      {
        get { return _analyzed; }
        set { _analyzed = value; }
      }
      
      private bool _repaired = false;
      
      public bool repaired
      {
        get { return _repaired; }
        set { _repaired = value; }
      }

      private List<Tasks> _recipe;
      
      public List<Tasks> recipe
      {
        get { return _recipe; }
        set { _recipe = value; }
      }
  }

}