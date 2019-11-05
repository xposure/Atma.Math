using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Atma.Math.Types;

namespace Atma.Math
{
    class Program
    {
        public static string Namespace = "Atma.Math";

        private static bool IsRunningFromGenerateDirectory(out string rootPath)
        {
            var path = Path.GetDirectoryName(Environment.CurrentDirectory);
            rootPath = path;
            var folders = new string[] { "generator", "source", "tests" };
            return folders.All(x => Directory.Exists(Path.Combine(path, x)));
        }

        private static void Main(string[] args)
        {
            if (!IsRunningFromGenerateDirectory(out var basePath))
            {
                Console.WriteLine("I suggest you use `dotnet run` form the generator source folder");
                return;
            }

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Atma.Math Generator");

            var path = Path.Combine(basePath, "source\\Atma\\Math");
            var testpath = Path.Combine(basePath, "tests\\Atma\\Math");
            Console.WriteLine($"Path: {path}");
            Console.WriteLine($"TestPath: {testpath}");

            AbstractType.Version = 45;
            Console.WriteLine($"Initing types, version: {AbstractType.Version}");
            AbstractType.InitTypes();

            // see: https://www.opengl.org/sdk/docs/man4/html/ for functions

            foreach (var type in AbstractType.Types.Values)
            {
                Console.WriteLine("Processing " + type.NameThat);
                // generate lib code
                {
                    var filename = type.PathOf(path);
                    new FileInfo(filename).Directory?.Create();
                    if (type.CSharpFile.WriteToFileIfChanged(filename))
                        Console.WriteLine("    CHANGED " + filename);
                }
                {
                    var filename = type.GlmPathOf(path);
                    new FileInfo(filename).Directory?.Create();
                    if (type.GlmSharpFile.WriteToFileIfChanged(filename))
                        Console.WriteLine("    CHANGED " + filename);
                }

                // generate test code
                if (!string.IsNullOrEmpty(testpath))
                {
                    var filename = type.TestPathOf(Path.Combine(testpath, "Generated"));
                    new FileInfo(filename).Directory?.Create();
                    if (type.TestFile.WriteToFileIfChanged(filename))
                        Console.WriteLine("    CHANGED " + filename);
                }

            }
            //Console.Read();
        }
    }
}
