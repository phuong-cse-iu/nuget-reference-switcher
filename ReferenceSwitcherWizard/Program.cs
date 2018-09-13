using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ReferenceSwitcherWizard.Models;

namespace ReferenceSwitcherWizard
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectReference projectReference = new ProjectReference();
            projectReference.Directory = "dir";
            projectReference.ProjectGuid = "123456";
            projectReference.ProjectName = "MyTool";

            Console.WriteLine(FileUtils.BuildProjReferenceNode(projectReference).ToString());

            Console.ReadLine();

        }
    }
}
