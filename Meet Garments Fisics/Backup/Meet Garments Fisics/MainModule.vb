Imports System.Data
Imports System.Data.OleDb

Module MainModule
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\SDPdatabase.mdb")
    Public cmd, cmd1, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7 As New OleDbCommand
    Public adp, adp1, adp2, adp3, adp4, adp5, adp6, adp7 As New OleDbDataAdapter
    Public ds, ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
End Module
