using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;
using workbenches;

public class Television : BaseObject
{
  public Television()
  {
    recipe = new List<BaseWorkbench> ();
    recipe.Add(new Scanner());
    recipe.Add(new Screw());
    recipe.Add(new Braze());
    recipe.Add(new Screw());
  }

  private void Start() {
    print("On start for laptop");
  }
}