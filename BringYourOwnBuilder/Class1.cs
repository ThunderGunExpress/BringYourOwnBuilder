using System;
using System.Web.Compilation;
using System.Windows.Forms;

namespace BringYourOwnBuilder
{
    public class GoHaveFun : BuildProvider
    {
        public override void GenerateCode(AssemblyBuilder assemblyBuilder)
        {
            MessageBox.Show("Bruins Stink. Leafs for the Cup.");
        }

    }
}
