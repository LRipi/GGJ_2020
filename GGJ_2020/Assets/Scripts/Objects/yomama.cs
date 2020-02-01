using System.Net.Mail;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;

public class yomama : BaseObject
{
  public yomama()
  {
    recipe = new List<Tasks> ();
    recipe.Add(Tasks.analyze);
    recipe.Add(Tasks.screw);
    recipe.Add(Tasks.hammer);
    recipe.Add(Tasks.connect);
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