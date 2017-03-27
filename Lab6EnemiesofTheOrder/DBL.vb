
Imports System.Data, System.Data.SqlClient

' Database Code Generated on 2017-03-22 5:14:43 PM by Mohammad  Al Jarrah & Raymonde Thompson
Namespace DBL

    Public Class Conn
        Public Shared Function getConnectionString() As String
            Return My.Settings.dbConn
        End Function
    End Class

    Public Class Tables

        Partial Public Class datEnemy

#Region " -- Constants -- "
            Public Class Fields
                Public Const enemyID As String = "enemyID"
                Public Const firstName As String = "firstName"
                Public Const lastName As String = "lastName"
                Public Const threatLevelID As String = "threatLevelID"
                Public Const allianceID As String = "allianceID"
                Public Const notes As String = "notes"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM [datEnemy]"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [datEnemy] WHERE [enemyID] = @Key"
                Public Const INSERT_NEW As String = "INSERT INTO datEnemy VALUES(@firstName, @lastName, @threatLevelID, @allianceID, @notes)"
                Public Const UPDATE_EXISING As String = "UPDATE datEnemy Set firstName  = @firstName, lastName  = @lastName, threatLevelID  = @threatLevelID, allianceID  = @allianceID, notes  = @notes WHERE enemyID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM [datEnemy] WHERE [enemyID] = @Key"
            End Class

#End Region

#Region "-- Properties --"
            Private _enemyID As Integer
            Public Property enemyID() As Integer
                Get
                    Return _enemyID
                End Get
                Set(ByVal value As Integer)
                    _enemyID = value
                End Set
            End Property

            Private _firstName As String
            Public Property firstName() As String
                Get
                    Return _firstName
                End Get
                Set(ByVal value As String)
                    _firstName = value
                End Set
            End Property

            Private _lastName As String
            Public Property lastName() As String
                Get
                    Return _lastName
                End Get
                Set(ByVal value As String)
                    _lastName = value
                End Set
            End Property

            Private _threatLevelID As Integer
            Public Property threatLevelID() As Integer
                Get
                    Return _threatLevelID
                End Get
                Set(ByVal value As Integer)
                    _threatLevelID = value
                End Set
            End Property

            Private _allianceID As Integer
            Public Property allianceID() As Integer
                Get
                    Return _allianceID
                End Get
                Set(ByVal value As Integer)
                    _allianceID = value
                End Set
            End Property

            Private _notes As String
            Public Property notes() As String
                Get
                    Return _notes
                End Get
                Set(ByVal value As String)
                    _notes = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(enemyID_ As Integer, firstName_ As String, lastName_ As String, threatLevelID_ As Integer, allianceID_ As Integer, notes_ As String)
                Dim Row As New datEnemy(0)
                enemyID = 0
                firstName = firstName_
                lastName = lastName_
                threatLevelID = threatLevelID_
                allianceID = allianceID_
                notes = notes_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New datEnemy(0)
                    Row = getOneRow(ID)
                    enemyID = Row.enemyID
                    firstName = Row.firstName
                    lastName = Row.lastName
                    threatLevelID = Row.threatLevelID
                    allianceID = Row.allianceID
                    notes = Row.notes
                End If
            End Sub
            Public Sub New()
                enemyID = 0
                firstName = String.Empty
                lastName = String.Empty
                threatLevelID = 1
                allianceID = 1
                notes = String.Empty
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRow(PK As Integer) As datEnemy
                Dim returnRow As New datEnemy(0)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.enemyID = PK
                        If Not IsDBNull(dR(Fields.firstName)) Then returnRow.firstName = dR(Fields.firstName)
                        If Not IsDBNull(dR(Fields.lastName)) Then returnRow.lastName = dR(Fields.lastName)
                        If Not IsDBNull(dR(Fields.threatLevelID)) Then returnRow.threatLevelID = dR(Fields.threatLevelID)
                        If Not IsDBNull(dR(Fields.allianceID)) Then returnRow.allianceID = dR(Fields.allianceID)
                        If Not IsDBNull(dR(Fields.notes)) Then returnRow.notes = dR(Fields.notes)
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function
            Public Shared Function getAllRows() As Generic.List(Of datEnemy)
                Dim returnRows As New Generic.List(Of datEnemy)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New datEnemy(0)
                        If Not IsDBNull(dR(Fields.enemyID)) Then Row.enemyID = dR(Fields.enemyID)
                        If Not IsDBNull(dR(Fields.firstName)) Then Row.firstName = dR(Fields.firstName)
                        If Not IsDBNull(dR(Fields.lastName)) Then Row.lastName = dR(Fields.lastName)
                        If Not IsDBNull(dR(Fields.threatLevelID)) Then Row.threatLevelID = dR(Fields.threatLevelID)
                        If Not IsDBNull(dR(Fields.allianceID)) Then Row.allianceID = dR(Fields.allianceID)
                        If Not IsDBNull(dR(Fields.notes)) Then Row.notes = dR(Fields.notes)
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As datEnemy) As Integer
                Dim ReturnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.connectionstring = Conn.getConnectionString

                Dim command As New SqlCommand
                command.connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@firstName", Row.firstName)
                command.Parameters.AddWithValue("@lastName", Row.lastName)
                command.Parameters.AddWithValue("@threatLevelID", Row.threatLevelID)
                command.Parameters.AddWithValue("@allianceID", Row.allianceID)
                command.Parameters.AddWithValue("@notes", Row.notes)
                Try
                    connDB.Open()
                    ReturnValue = (command.ExecuteNonQuery = 1)
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return ReturnValue
            End Function
            Public Shared Function updateExistingRow(Row As datEnemy) As Boolean
                Dim ReturnValue As Boolean = False
                If Row.enemyID >= 0 Then
                    Dim connDB As New SqlConnection
                    connDB.ConnectionString = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.Connection = connDB
                    command.CommandType = CommandType.Text
                    command.CommandText = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.enemyID)
                    command.Parameters.AddWithValue("@firstName", Row.firstName)
                    command.Parameters.AddWithValue("@lastName", Row.lastName)
                    command.Parameters.AddWithValue("@threatLevelID", Row.threatLevelID)
                    command.Parameters.AddWithValue("@allianceID", Row.allianceID)
                    command.Parameters.AddWithValue("@notes", Row.notes)
                    Try
                        connDB.Open()
                        If command.ExecuteNonQuery > 0 Then ReturnValue = True
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    If insertNewRow(Row) > 0 Then ReturnValue = True
                End If
                Return ReturnValue
            End Function
            Public Shared Function deleteRow(PK As Integer) As Boolean
                Dim returnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.connectionstring = Conn.getConnectionString

                Dim command As New SqlCommand
                command.connection = connDB
                command.CommandType = CommandType.Text
                command.commandtext = SQLStatements.DELETE_EXISTING
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    returnValue = command.ExecuteNonQuery() > 0
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnValue
            End Function
#End Region
        End Class

        Partial Public Class lstThreatLevel

#Region " -- Constants -- "
            Public Class Fields
                Public Const levelID As String = "levelID"
                Public Const threatLevel As String = "threatLevel"
                Public Const priority As String = "priority"
                Public Const isActive As String = "isActive"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM [lstThreatLevel]"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [lstThreatLevel] WHERE [levelID] = @Key"
                Public Const INSERT_NEW As String = "INSERT INTO lstThreatLevel VALUES(@threatLevel, @priority, @isActive)"
                Public Const UPDATE_EXISING As String = "UPDATE lstThreatLevel Set threatLevel  = @threatLevel, priority  = @priority, isActive  = @isActive WHERE levelID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM [lstThreatLevel] WHERE [levelID] = @Key"
            End Class

#End Region

#Region "-- Properties --"
            Private _levelID As Integer
            Public Property levelID() As Integer
                Get
                    Return _levelID
                End Get
                Set(ByVal value As Integer)
                    _levelID = value
                End Set
            End Property

            Private _threatLevel As String
            Public Property threatLevel() As String
                Get
                    Return _threatLevel
                End Get
                Set(ByVal value As String)
                    _threatLevel = value
                End Set
            End Property

            Private _priority As Integer
            Public Property priority() As Integer
                Get
                    Return _priority
                End Get
                Set(ByVal value As Integer)
                    _priority = value
                End Set
            End Property

            Private _isActive As Boolean
            Public Property isActive() As Boolean
                Get
                    Return _isActive
                End Get
                Set(ByVal value As Boolean)
                    _isActive = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(levelID_ As Integer, threatLevel_ As String, priority_ As Integer, isActive_ As Boolean)
                Dim Row As New lstThreatLevel(0)
                levelID = 0
                threatLevel = threatLevel_
                priority = priority_
                isActive = isActive_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New lstThreatLevel(0)
                    Row = getOneRow(ID)
                    levelID = Row.levelID
                    threatLevel = Row.threatLevel
                    priority = Row.priority
                    isActive = Row.isActive
                End If
            End Sub
            Public Sub New()
                levelID = 0
                threatLevel = String.Empty
                priority = 10
                isActive = True
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRow(PK As Integer) As lstThreatLevel
                Dim returnRow As New lstThreatLevel(0)
                Dim connDB As New SqlConnection
                connDB.connectionstring = Conn.getConnectionString

                Dim command As New SqlCommand
                command.connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.levelID = PK
                        If Not IsDBNull(dR(Fields.threatLevel)) Then returnRow.threatLevel = dR(Fields.threatLevel)
                        If Not IsDBNull(dR(Fields.priority)) Then returnRow.priority = dR(Fields.priority)
                        If Not IsDBNull(dR(Fields.isActive)) Then returnRow.isActive = dR(Fields.isActive)
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function
            Public Shared Function getAllRows() As Generic.List(Of lstThreatLevel)
                Dim returnRows As New Generic.List(Of lstThreatLevel)
                Dim connDB As New SqlConnection
                connDB.connectionstring = Conn.getConnectionString

                Dim command As New SqlCommand
                command.connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New lstThreatLevel(0)
                        If Not IsDBNull(dR(Fields.levelID)) Then Row.levelID = dR(Fields.levelID)
                        If Not IsDBNull(dR(Fields.threatLevel)) Then Row.threatLevel = dR(Fields.threatLevel)
                        If Not IsDBNull(dR(Fields.priority)) Then Row.priority = dR(Fields.priority)
                        If Not IsDBNull(dR(Fields.isActive)) Then Row.isActive = dR(Fields.isActive)
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As lstThreatLevel) As Integer
                Dim ReturnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.connectionstring = Conn.getConnectionString

                Dim command As New SqlCommand
                command.connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@threatLevel", Row.threatLevel)
                command.Parameters.AddWithValue("@priority", Row.priority)
                command.Parameters.AddWithValue("@isActive", Row.isActive)
                Try
                    connDB.Open()
                    ReturnValue = (command.ExecuteNonQuery = 1)
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return ReturnValue
            End Function
            Public Shared Function updateExistingRow(Row As lstThreatLevel) As Boolean
                Dim ReturnValue As Boolean = False
                If Row.levelID > 0 Then
                    Dim connDB As New SqlConnection
                    connDB.connectionstring = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.connection = connDB
                    command.CommandType = CommandType.Text
                    command.commandtext = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.levelID)
                    command.Parameters.AddWithValue("@threatLevel", Row.threatLevel)
                    command.Parameters.AddWithValue("@priority", Row.priority)
                    command.Parameters.AddWithValue("@isActive", Row.isActive)
                    Try
                        connDB.Open()
                        If command.ExecuteNonQuery > 0 Then ReturnValue = True
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    If insertNewRow(Row) > 0 Then ReturnValue = True
                End If
                Return ReturnValue
            End Function
            Public Shared Function deleteRow(PK As Integer) As Boolean
                Dim returnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.connectionstring = Conn.getConnectionString

                Dim command As New SqlCommand
                command.connection = connDB
                command.CommandType = CommandType.Text
                command.commandtext = SQLStatements.DELETE_EXISTING
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    returnValue = command.ExecuteNonQuery() > 0
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnValue
            End Function
#End Region
        End Class

        Partial Public Class lstAlliances

#Region " -- Constants -- "
            Public Class Fields
                Public Const allianceID As String = "allianceID"
                Public Const allianceName As String = "allianceName"
                Public Const isActive As String = "isActive"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM [lstAlliances]"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [lstAlliances] WHERE [allianceID] = @Key"
                Public Const INSERT_NEW As String = "INSERT INTO lstAlliances VALUES(@allianceName, @isActive)"
                Public Const UPDATE_EXISING As String = "UPDATE lstAlliances Set allianceName  = @allianceName, isActive  = @isActive WHERE allianceID = @PK"
                Public Const DELETE_EXISTING As String = "DELETE FROM [lstAlliances] WHERE [allianceID] = @Key"
            End Class

#End Region

#Region "-- Properties --"
            Private _allianceID As Integer
            Public Property allianceID() As Integer
                Get
                    Return _allianceID
                End Get
                Set(ByVal value As Integer)
                    _allianceID = value
                End Set
            End Property

            Private _allianceName As String
            Public Property allianceName() As String
                Get
                    Return _allianceName
                End Get
                Set(ByVal value As String)
                    _allianceName = value
                End Set
            End Property

            Private _isActive As Boolean
            Public Property isActive() As Boolean
                Get
                    Return _isActive
                End Get
                Set(ByVal value As Boolean)
                    _isActive = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(allianceID_ As Integer, allianceName_ As String, isActive_ As Boolean)
                Dim Row As New lstAlliances(0)
                allianceID = 0
                allianceName = allianceName_
                isActive = isActive_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New lstAlliances(0)
                    Row = getOneRow(ID)
                    allianceID = Row.allianceID
                    allianceName = Row.allianceName
                    isActive = Row.isActive
                End If
            End Sub
            Public Sub New()
                allianceID = 0
                allianceName = String.Empty
                isActive = True
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRow(PK As Integer) As lstAlliances
                Dim returnRow As New lstAlliances(0)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.allianceID = PK
                        If Not IsDBNull(dR(Fields.allianceName)) Then returnRow.allianceName = dR(Fields.allianceName)
                        If Not IsDBNull(dR(Fields.isActive)) Then returnRow.isActive = dR(Fields.isActive)
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function
            Public Shared Function getAllRows() As Generic.List(Of lstAlliances)
                Dim returnRows As New Generic.List(Of lstAlliances)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New lstAlliances(0)
                        If Not IsDBNull(dR(Fields.allianceID)) Then Row.allianceID = dR(Fields.allianceID)
                        If Not IsDBNull(dR(Fields.allianceName)) Then Row.allianceName = dR(Fields.allianceName)
                        If Not IsDBNull(dR(Fields.isActive)) Then Row.isActive = dR(Fields.isActive)
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As lstAlliances) As Integer
                Dim ReturnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@allianceName", Row.allianceName)
                command.Parameters.AddWithValue("@isActive", Row.isActive)
                Try
                    connDB.Open()
                    ReturnValue = (command.ExecuteNonQuery = 1)
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return ReturnValue
            End Function
            Public Shared Function updateExistingRow(Row As lstAlliances) As Boolean
                Dim ReturnValue As Boolean = False
                If Row.allianceID > 0 Then
                    Dim connDB As New SqlConnection
                    connDB.ConnectionString = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.Connection = connDB
                    command.CommandType = CommandType.Text
                    command.CommandText = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.allianceID)
                    command.Parameters.AddWithValue("@allianceName", Row.allianceName)
                    command.Parameters.AddWithValue("@isActive", Row.isActive)
                    Try
                        connDB.Open()
                        If command.ExecuteNonQuery > 0 Then ReturnValue = True
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    If insertNewRow(Row) > 0 Then ReturnValue = True
                End If
                Return ReturnValue
            End Function
            Public Shared Function deleteRow(PK As Integer) As Boolean
                Dim returnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.DELETE_EXISTING
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    returnValue = command.ExecuteNonQuery() > 0
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnValue
            End Function
#End Region
        End Class
    End Class
    Partial Public Class Views
        Public Class Enemies
#Region " -- Constants -- "
            Public Class Fields
                Public Const enemyID As String = "enemyID"
                Public Const lastName As String = "lastName"
                Public Const firstName As String = "firstName"
                Public Const threatLevelID As String = "threatLevelID"
                Public Const threatLevel As String = "threatLevel"
                Public Const allianceID As String = "allianceID"
                Public Const allianceName As String = "allianceName"
                Public Const isActive As String = "isActive"
                Public Const notes As String = "notes"
            End Class

#End Region

#Region " -- SQLStatements -- "
            Public Class SQLStatements
                Public Const SELECT_ALL As String = "SELECT * FROM [datEnemy] As d, [lstAlliances] As a, [lstThreatLevel] As t WHERE t.levelID = d.threatLevelID AND a.allianceID = d.allianceID"
                Public Const SELECT_1_BY_ID As String = "SELECT TOP 1 * FROM [datEnemy] As d, [lstAlliances] As a, [lstThreatLevel] As t 
                                                        WHERE  d.allianceID = a.allianceID AND d.threatLevelID = t.levelID AND d.[enemyID] = @Key"
                Public Const INSERT_NEW As String = "INSERT INTO [datEnemy] (
                                                    enemyID, fisrtName, lastName, threatLevelID, allianceID, notes 
                                                    ) VALUES (
                                                   @enemyID, @firstName, @lastName, @threatLevelID, @allianceID, @notes
                                                    )"
                Public Const UPDATE_EXISING As String = "UPDATE [datEnemy] Set firstName  = @firstName, lastName  = @lastName, threatLevelID  = @threatLevelID, allianceID  = @allianceID, notes  = @notes WHERE enemyID = @PK"
            End Class

#End Region

#Region "-- Properties --"
            Private _allianceID As Integer
            Public Property allianceID() As Integer
                Get
                    Return _allianceID
                End Get
                Set(ByVal value As Integer)
                    _allianceID = value
                End Set
            End Property

            Private _allianceName As String
            Public Property allianceName() As String
                Get
                    Return _allianceName
                End Get
                Set(ByVal value As String)
                    _allianceName = value
                End Set
            End Property

            Private _isActive As Boolean
            Public Property isActive() As Boolean
                Get
                    Return _isActive
                End Get
                Set(ByVal value As Boolean)
                    _isActive = value
                End Set
            End Property

            Private _enemyID As Integer
            Public Property enemyID() As Integer
                Get
                    Return _enemyID
                End Get
                Set(ByVal value As Integer)
                    _enemyID = value
                End Set
            End Property

            Private _firstName As String
            Public Property firstName() As String
                Get
                    Return _firstName
                End Get
                Set(ByVal value As String)
                    _firstName = value
                End Set
            End Property

            Private _lastName As String
            Public Property lastName() As String
                Get
                    Return _lastName
                End Get
                Set(ByVal value As String)
                    _lastName = value
                End Set
            End Property

            Private _threatLevel As String
            Public Property threatLevel() As String
                Get
                    Return _threatLevel
                End Get
                Set(ByVal value As String)
                    _threatLevel = value
                End Set
            End Property

            Private _threatLevelID As Integer
            Public Property threatLevelID() As Integer
                Get
                    Return _threatLevelID
                End Get
                Set(ByVal value As Integer)
                    _threatLevelID = value
                End Set
            End Property

            Private _notes As String
            Public Property notes() As String
                Get
                    Return _notes
                End Get
                Set(ByVal value As String)
                    _notes = value
                End Set
            End Property

#End Region

#Region " -- Constructors -- "
            Public Sub New(enemyID_ As Integer, firstName_ As String, lastName_ As String, theatLevelID_ As Integer, notes_ As String, allianceID_ As Integer, allianceName_ As String, isActive_ As Boolean)
                Dim Row As New Views.Enemies(0)
                enemyID = 0
                firstName = firstName_
                lastName = lastName_
                threatLevelID = theatLevelID_
                allianceID = allianceID_
                notes = notes_
                allianceName = allianceName_
                isActive = isActive_
            End Sub

            Public Sub New(ID As Integer)
                If ID > 0 Then
                    Dim Row As New Views.Enemies(0)
                    Row = getEnemyList(ID)
                    allianceID = Row.allianceID
                    allianceName = Row.allianceName
                    isActive = Row.isActive
                End If
            End Sub
            Public Sub New()
                enemyID = 0
                firstName = String.Empty
                lastName = String.Empty
                threatLevelID = 1
                allianceID = 1
                notes = String.Empty
                allianceName = String.Empty
                isActive = True
            End Sub

#End Region

#Region "-- Generic Methods --"
            Public Shared Function getOneRow(PK As Integer) As Enemies
                Dim returnRow As New Enemies(0)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_1_BY_ID
                command.Parameters.AddWithValue("@Key", PK)
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    If dR.Read() Then
                        returnRow.enemyID = PK
                        If Not IsDBNull(dR(Fields.firstName)) Then returnRow.firstName = dR(Fields.firstName)
                        If Not IsDBNull(dR(Fields.lastName)) Then returnRow.lastName = dR(Fields.lastName)
                        If Not IsDBNull(dR(Fields.threatLevelID)) Then returnRow.threatLevelID = dR(Fields.threatLevelID)
                        If Not IsDBNull(dR(Fields.threatLevel)) Then returnRow.threatLevel = dR(Fields.threatLevel)
                        If Not IsDBNull(dR(Fields.allianceID)) Then returnRow.allianceID = dR(Fields.allianceID)
                        If Not IsDBNull(dR(Fields.allianceName)) Then returnRow.allianceName = dR(Fields.allianceName)
                        If Not IsDBNull(dR(Fields.notes)) Then returnRow.notes = dR(Fields.notes)
                    End If
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRow
            End Function

            Public Shared Function getEnemyList() As Generic.List(Of Views.Enemies)
                Dim returnRows As New Generic.List(Of Views.Enemies)
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.SELECT_ALL
                Try
                    connDB.Open()
                    Dim dR As IDataReader = command.ExecuteReader
                    Do While dR.Read()
                        Dim Row As New Views.Enemies(0)
                        If Not IsDBNull(dR(Fields.enemyID)) Then Row.enemyID = dR(Fields.enemyID)
                        If Not IsDBNull(dR(Fields.allianceID)) Then Row.allianceID = dR(Fields.allianceID)
                        If Not IsDBNull(dR(Fields.allianceName)) Then Row.allianceName = dR(Fields.allianceName)
                        If Not IsDBNull(dR(Fields.firstName)) Then Row.firstName = dR(Fields.firstName)
                        If Not IsDBNull(dR(Fields.lastName)) Then Row.lastName = dR(Fields.lastName)
                        If Not IsDBNull(dR(Fields.threatLevelID)) Then Row.threatLevelID = dR(Fields.threatLevelID)
                        If Not IsDBNull(dR(Fields.notes)) Then Row.notes = dR(Fields.notes)
                        If Not IsDBNull(dR(Fields.isActive)) Then Row.isActive = dR(Fields.isActive)
                        returnRows.Add(Row)
                    Loop
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return returnRows
            End Function
            Public Shared Function insertNewRow(Row As Enemies) As Integer
                Dim ReturnValue As Boolean = False
                Dim connDB As New SqlConnection
                connDB.ConnectionString = Conn.getConnectionString

                Dim command As New SqlCommand
                command.Connection = connDB
                command.CommandType = CommandType.Text
                command.CommandText = SQLStatements.INSERT_NEW
                command.Parameters.AddWithValue("@enemyID", Row.enemyID)
                command.Parameters.AddWithValue("@firstName", Row.firstName)
                command.Parameters.AddWithValue("@lastName", Row.lastName)
                command.Parameters.AddWithValue("@threatLevelID", Row.threatLevelID)
                command.Parameters.AddWithValue("@allianceID", Row.allianceID)
                command.Parameters.AddWithValue("@allianceName", Row.allianceName)
                command.Parameters.AddWithValue("@notes", Row.notes)
                command.Parameters.AddWithValue("@isActive", Row.isActive)

                Try
                    connDB.Open()
                    ReturnValue = (command.ExecuteNonQuery = 1)
                Catch ex As Exception
                    Console.WriteLine(Err.Description)
                End Try
                Return ReturnValue
            End Function
            Public Shared Function updateExistingRow(Row As Enemies) As Boolean
                Dim ReturnValue As Boolean = False
                If Row.enemyID >= 0 Then
                    Dim connDB As New SqlConnection
                    connDB.ConnectionString = Conn.getConnectionString

                    Dim command As New SqlCommand
                    command.Connection = connDB
                    command.CommandType = CommandType.Text
                    command.CommandText = SQLStatements.UPDATE_EXISING
                    command.Parameters.AddWithValue("@PK", Row.enemyID)
                    command.Parameters.AddWithValue("@firstName", Row.firstName)
                    command.Parameters.AddWithValue("@lastName", Row.lastName)
                    command.Parameters.AddWithValue("@theatLevelID", Row.threatLevelID)
                    command.Parameters.AddWithValue("@allianceID", Row.allianceID)
                    command.Parameters.AddWithValue("@allianceName", Row.allianceName)
                    command.Parameters.AddWithValue("@notes", Row.notes)
                    command.Parameters.AddWithValue("@isActive", Row.isActive)
                    Try
                        connDB.Open()
                        If command.ExecuteNonQuery > 0 Then ReturnValue = True
                    Catch ex As Exception
                        Console.WriteLine(Err.Description)
                    End Try
                Else
                    If insertNewRow(Row) > 0 Then ReturnValue = True
                End If
                Return ReturnValue
            End Function
#End Region

        End Class
    End Class
End Namespace



