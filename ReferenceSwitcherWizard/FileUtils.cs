using ReferenceSwitcherWizard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ReferenceSwitcherWizard
{
    class FileUtils
    {

        public static List<DirectoryConfiguration> GetListOfRefDirectoryFromConfigFile(String path)
        {
            XDocument doc = XDocument.Load(path);
            List<DirectoryConfiguration> dirConfigurations = new List<DirectoryConfiguration>();

            foreach (XElement reference in doc.Root.Elements("reference"))
            {
                var configuration = new DirectoryConfiguration();
                configuration.NugetRefDirectory = reference.Element("NugetReference").Value;
                configuration.ProjectRefeDirectory = reference.Element("ProjectReference").Value;

                dirConfigurations.Add(configuration);
            }
            return dirConfigurations;
        }

        public static bool IsFileExisted(String path)
        {
            return File.Exists(path);
        }

        public static void BackUpFile(String path)
        {
            if (IsFileExisted(path))
            {
                
            } 
        }

        public static XElement BuildProjReferenceNode(ProjectReference projectReference)
        {   
            // <ProjectReference></ProjectReference>
            var el = new XElement("ProjectReference");
            // <ProjectReference Include=""></ProjectReference>
            el.Add(new XAttribute("Include", projectReference.Directory));

            return el;
        }
    }
}
