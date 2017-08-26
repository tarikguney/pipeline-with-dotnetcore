using System;
using System.Runtime.Loader;
using System.IO;
using System.Linq;
using System.Xml;
using System.Collections.Generic;
using Common;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipelineContent = File.ReadAllText("Pipeline.xml");
            var pipelineXml = new XmlDocument();
            pipelineXml.LoadXml(pipelineContent);
            var processNodes = pipelineXml.SelectNodes("/Pipeline/Process").Cast<XmlNode>();
            var types = new List<Type>();

            var currentPath = Directory.GetParent(typeof(Program).Assembly.Location);

            foreach (var processNode in processNodes)
            {
                var assemblyName = processNode.Attributes["Assembly"].Value;
                var typeName = processNode.Attributes["Type"].Value;

                var assembly = AssemblyLoadContext.Default
                    .LoadFromAssemblyPath(Path.Combine(currentPath.FullName, assemblyName));
                types.Add(assembly.GetExportedTypes().First(a => a.FullName == typeName));
            }

            var pipelineObjects = types.Select(a => Activator.CreateInstance(a)).Cast<IAccountPipeline>();
            var account = new Account();
            account.FirstName = "Tarik";
            account.LastName = "Guney";
            account.Balance = 1000;

            foreach(pipelineObject in pipelineObjects){
            {
                pipelineObject.Process(account);
            }
            ObjectDumper.Write(account, 1, Console.Out);
        }
    }
}
