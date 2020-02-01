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
    Console.writeLine("OnStart");
  }

  private void Update() {
    Console.writeLine("OnPause");
  }

  private void OnApplicationPause(bool pauseStatus) {
    Console.writeLine("OnPause");
  }
}