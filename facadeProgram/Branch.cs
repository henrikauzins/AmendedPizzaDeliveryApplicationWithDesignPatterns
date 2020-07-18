using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // used for the location of the specific pizza delivery branch
    public class Branch
    {
        // name of pizza branch declared
        private string branchName;
        public Branch(string BranchName)
        {
            branchName = BranchName;
        }

        public string GetBranch()
        {
            // returns the name of the pizza branch
            return branchName;
        }
    }
}
