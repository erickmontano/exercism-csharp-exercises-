public static class SecretHandshake
{
    [Flags]
    enum Handshake
    {
        Wink = 1,  // 00001
        DoubleBlink = 2,  // 00010
        CloseEyes = 4,  // 00100
        Jump = 8,  // 01000
        Reverse = 16  // 10000
    }

    public static string[] Commands(int commandValue)
    {
        List<string> commands = [];

        Handshake action = (Handshake)commandValue;

        if (action.HasFlag(Handshake.Wink))
            commands.Add("wink");
        if (action.HasFlag(Handshake.DoubleBlink))
            commands.Add("double blink");
        if (action.HasFlag(Handshake.CloseEyes))
            commands.Add("close your eyes");
        if (action.HasFlag(Handshake.Jump))
            commands.Add("jump");
        if (action.HasFlag(Handshake.Reverse))
            commands.Reverse();

        return commands.ToArray();
    }
}
