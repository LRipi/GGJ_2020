using System.Diagnostics;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;

using baseComponents;

namespace workbenches
{
    public class Braze : BaseWorkbench
    {
        // Start is called before the first frame update

        public Braze()
        {
            name = "Brazing Table";
        }
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void put()
        {
            print("Something has been put on the brazing table");
        }
    }
}
