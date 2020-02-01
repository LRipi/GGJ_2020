using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;

public class TV : BaseObject
{
  public TV()
  {
    recipe = new List<Tasks> ();
    recipe.Add(Tasks.analyze);
    recipe.Add(Tasks.clean);
    recipe.Add(Tasks.screw);
  }
  private void Start() {
    print("OnStart");
  }

  private void Update() {
    print("OnPause");
  }

  private void OnApplicationPause(bool pauseStatus) {
    print("OnPause");
  }
}