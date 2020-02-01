using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;

public class Motor : BaseObject
{
  public Motor()
  {
    recipe = new List<Tasks> ();
    recipe.Add(Tasks.analyze);
    recipe.Add(Tasks.clean);
    recipe.Add(Tasks.hammer);
    recipe.Add(Tasks.screw);
    recipe.Add(Tasks.solder);
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