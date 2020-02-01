using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;

public class Laptop : BaseObject
{
  public Laptop()
  {
    recipe = new List<Tasks> ();
    recipe.Add(Tasks.analyze);
    recipe.Add(Tasks.connect);
    recipe.Add(Tasks.solder);
    recipe.Add(Tasks.clean);
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