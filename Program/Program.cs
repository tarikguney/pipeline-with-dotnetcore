using System;
using System.Runtime.Loader;
using System.IO;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentAssembly = typeof(Program).Assembly;
            var currentPath = currentAssembly.Location;
            var currentDirectory = Directory.GetParent(currentPath).FullName;
            var assemblies = Directory
                .GetFiles(currentDirectory, "*.dll")
                .Select(f => Path.GetFileName(f))
                .Except(new[] { $"{currentAssembly.GetName().Name}.dll" });

            foreach(var assemblyName in assemblies){
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyName);
                // Removing this code...
            }
        }
    }
}
