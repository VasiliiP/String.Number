using System;
using System.IO;

namespace Number.String.Sorter;

public static class Helpers
{
    public static string GetParentDirectory(int level, string path)
    {
        if (path == null) throw new ArgumentNullException(nameof(path));
        
        return level <= 0 
            ? path 
            : GetParentDirectory(level - 1, Path.GetDirectoryName(path));

        var currentDir = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
    }
}