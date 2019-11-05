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

        private static string GetRootDirectory()
        {
            var path = Environment.CurrentDirectory;
            while (string.Compare(Path.GetFileName(path), "source", true) != 0)
                path = Path.GetDirectoryName(path);

            return path;
        }

        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Atma.Math Generator");

            var basePath = GetRootDirectory();
            var path = Path.Combine(basePath, "Atma.Math\\source\\Intrinsic\\Math");
            var testpath = Path.Combine(basePath, "Atma.Math\\tests\\Intrinsic\\Math");

            AbstractType.Version = 45;
            AbstractType.InitTypes();

            // see: https://www.opengl.org/sdk/docs/man4/html/ for functions

            foreach (var type in AbstractType.Types.Values)
            {
                //Console.WriteLine("Processing " + type.NameTha);
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
            Console.Read();
        }
    }
}
