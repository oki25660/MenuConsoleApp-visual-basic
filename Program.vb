Imports System

Module Program
    Sub Main(args As String())
        Do
            Dim Imput As Integer = 0
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("                                                            *ITHEC*")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("")
            Console.WriteLine("                                                         MENU PRICIPAL")
            Console.WriteLine("                                                  *=========================*")
            Console.WriteLine("                                                         * 1. DISKPART")
            Console.WriteLine("                                                         * 2. GETMAC")
            Console.WriteLine("                                                         * 3. BCDEDIT")
            Console.WriteLine("                                                         * 4. TASKLIST")
            Console.WriteLine("                                                         * 5. NET START")
            Console.WriteLine("                                                         * 6. IP CONFIG")
            Console.WriteLine("                                                         * 0. QUITER APP")
            Console.WriteLine("                                                  *=========================*")
            Console.WriteLine("                                                      Choisisez une option : ")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("")
            Console.WriteLine("                                       ** Pour Choisir a nouveau appuyer sur Enter **")
            If Integer.TryParse(Console.ReadLine(), Imput) Then
                Select Case Imput
                    Case 1
                        Process.Start("CMD", "/C diskpart & pause")
                    Case 2
                        Process.Start("CMD", "/C powershell.exe getmac")
                    Case 3
                        Process.Start("CMD", "/C bcdedit & pause")
                    Case 4
                        Process.Start("CMD", "/C tasklist & pause")
                    Case 5
                        Process.Start("CMD", "/C net start & pause")
                    Case 6
                        Process.Start("CMD", "/C ipconfig & pause")
                    Case 0
                        Exit Sub
                    Case Else
                End Select
            End If
            Console.Clear()
        Loop
    End Sub
End Module

