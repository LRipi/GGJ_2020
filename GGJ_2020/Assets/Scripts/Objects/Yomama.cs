using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;
using workbenches;

public class Yomama : BaseObject
{
  public Yomama()
  {
    recipe = new List<BaseWorkbench> ();
    recipe.Add(new Scanner());
    recipe.Add(new Screw());
    recipe.Add(new Braze());
    recipe.Add(new Hammer());
    recipe.Add(new Nail());
  }

  private void Start() {
    print("On start for laptop");
  }
}