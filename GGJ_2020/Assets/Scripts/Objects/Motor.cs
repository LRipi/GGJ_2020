using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;
using workbenches;

public class Motor : BaseObject
{
  public Motor()
  {
    recipe = new List<BaseWorkbench> ();
    recipe.Add(new Scanner());
    recipe.Add(new Hammer());
    recipe.Add(new Screw());
    recipe.Add(new Screw());
  }

  private void Start() {
    print("On start for laptop");
  }
}