using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileStudy
{
    class SimpleIO
    {
        public static void ExecuteSamples()
        {
            // writing to file
            // writing full string
            string content = "Este arquivo foi criado pelo programa de exemplo de uso de file com c#";

            File.WriteAllText("file_study_write.txt", content);
            // writing array of strings
            string[] lines = { content, "Segunda Linha", "Terceira Linha" };

            File.WriteAllLines("file_study_write_lines.txt", lines);

            // reading from file
            // reading full content
            string file_content = File.ReadAllText("file_study_write.txt");
            // reading full lines
            string[] file_lines = File.ReadAllLines("file_study_write_lines.txt");
        }
    }
}
