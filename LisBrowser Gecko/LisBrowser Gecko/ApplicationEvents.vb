Imports Gecko
Imports System.IO

Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst.  Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung mit einem Fehler beendet wird.
    ' UnhandledException: Wird bei einem Ausnahmefehler ausgelöst.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn die Anwendung bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        Protected Overrides Function OnStartup(ByVal eventArgs As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean

            Dim ProfileDirectory As String = My.Application.Info.DirectoryPath & "\Firefox"

            If Not Directory.Exists(ProfileDirectory) Then
                Directory.CreateDirectory(ProfileDirectory)
            End If
            Xpcom.ProfileDirectory = ProfileDirectory

            Dim xrPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
            xrPath = My.Application.Info.DirectoryPath & "\Firefox"
            Xpcom.Initialize(xrPath)

            Return True
        End Function
    End Class
End Namespace
