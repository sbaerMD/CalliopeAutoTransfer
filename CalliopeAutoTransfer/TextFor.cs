namespace CalliopeAutoTransfer
{
    public class TextFor
    {
        public static string TransferSuccess(string fileName)
            => $"Datei '{fileName}' wurde auf Deinen Calliope übertragen!\nDu kannst den Calliope jetzt trennen.";

        public static string Connected => "verbunden";
        public static string Disconnected => "nicht verbunden";
        public static string AwaitingRestart => "empfängt Programm";
        public static string Restarting => "installiert Programm";
        public static string Restarted => "fertig";

        public static string CalliopeNotConnectedErrorMessage =>
            "Deinen Calliope ist nicht verbunden. Die Datei kann nicht übertragen werden.";
        public static string CalliopeNotConnectedErrorTitle => "Calliope nicht verbunden";

        public static string ErrorDialogTitle => "Fehler";

        public static string NoProjectFileText => "keine (neue) Übertragungsdatei";
    }
}
