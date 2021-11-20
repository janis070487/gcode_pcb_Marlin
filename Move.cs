using System;

public static class Move
{
    public static char[] UpZ()
    {
        char[] data = new char[]
        {
            'G', '1', ' ', 'Z', '1', '0', ' ', 'F', '1', '0', '0', '\n'
        };
        return data;
    }

    public static char[] DownZ()
    {
        char[] data = new char[]
        {
            'G', '1', ' ', 'Z', '1', '0', ' ', 'F', '0', '\n'
        };
        return data;
    }
}

