Module RegistryModule
    Const c_strKeyName As String =
        "HKEY_CURRENT_USER\Software\CleverSoftware\PictureViewer\"

    Public Property UserName As String
        Get
            Return CStr(My.Computer.Registry.GetValue(c_strKeyName, "UserName", ""))
        End Get
        Set(value As String)
            My.Computer.Registry.SetValue(c_strKeyName, "UserName", value)
        End Set
    End Property

    Public Property PromptOnExit As Boolean
        Get
            Return CBool(My.Computer.Registry.GetValue(c_strKeyName, "PromptOnExit", "0"))
        End Get
        Set(value As Boolean)
            My.Computer.Registry.SetValue(c_strKeyName, "PromptOnExit", value)
        End Set
    End Property

    Public Property BackColor As String
        Get
            Return My.Computer.Registry.GetValue(c_strKeyName, "BackColor", "Gray")
        End Get
        Set(value As String)
            My.Computer.Registry.SetValue(c_strKeyName, "BackColor", value)
        End Set
    End Property
End Module
