Module SimpleCalculator
    Public FirstInt As Double
    Public SecondInt As Double
    Public Op As String
    Public YN As String

    Sub Main()
        'ENGLISH: CLEAR THE CONSOLE
        'INDONESIA: MEMBERSIHKAN KONSOL
        Console.Clear()
#Region "1"
        'ENGLISH: CONSOLE WRITES  MESSAGE: "Hello! Welcome to Simple Calculator!".
        'INDONESIA: KONSOL MENULIS PESAN: "Hello! Welcome to Simple Calculator!".
        Console.WriteLine("Hello! Welcome to Simple Calculator!")
#End Region

#Region "2"
        'ENGLISH: CONSOLE READS THE LINE.
        'INDONESIA: KONSOL MEMBACA BARIS.
        Console.ReadLine()
#End Region

#Region "3"
        'ENGLISH: CONSOLE WRITES MESSAGE BELOW!
        'INDONESIA: KONSOL MENULIS PESAN DI BAWAH!
        Console.WriteLine("Enter The First Number:")
#End Region

#Region "4"
        'ENGLISH: THIS BLOCK CODE USE TO HANDLING AN EXCEPTION
        'INDONESIA: BLOK KODE INI DIGUNAKAN UNTUK MENGATASI PENGECUALIAN.
        Try

            FirstInt = Console.ReadLine()

        Catch ex As InvalidCastException
            Console.WriteLine("You've entered an invalid number!")
            Console.WriteLine("Enter The First Number!")
            FirstInt = Console.ReadLine()
        End Try
#End Region

#Region "5"
        Console.WriteLine("Enter the Second number!")
        Try

            SecondInt = Console.ReadLine()

        Catch ex As InvalidCastException

            Console.WriteLine("You've entered an invalid number!")
            Console.WriteLine("Enter The Second Number!")
            SecondInt = Console.ReadLine()

        End Try
#End Region

        Console.WriteLine("Enter the Operation! + Or - Or * Or /")

        Op = Console.ReadLine

        If Op = "+" Then

            Console.WriteLine("You Expression Will Be: " & FirstInt & " " & "+ " & SecondInt)
            Console.WriteLine("and the result is:")
            Console.WriteLine(FirstInt + SecondInt)
            Console.WriteLine("Again? y/n")
            YN = Console.ReadLine()

            If YN = "y" Then

                Main()

            Else

                Console.WriteLine("Sure Want to exit?(Press Enter Again To Exit!)")
                YN = Console.ReadLine()

                If YN = "n" Then

                    Main()

                Else

                End If

            End If

        ElseIf Op = "-" Then

            Console.WriteLine("You Expression Will Be: " & FirstInt & " " & "- " & SecondInt)
            Console.WriteLine("and the result is:")
            Console.WriteLine(FirstInt - SecondInt)
            Console.WriteLine("Again? y/n")
            YN = Console.ReadLine()

            If YN = "y" Then

                Main()

            Else

                Console.WriteLine("Sure Want to exit?(Press Enter Again To Exit!)")
                YN = Console.ReadLine()

                If YN = "n" Then

                    Main()

                Else

                End If


            End If
        ElseIf Op = "*" Then

            Console.WriteLine("You Expression Will Be:  " & FirstInt & " " & "*" & SecondInt)
            Console.WriteLine("and the result is:")

            Try

                Console.WriteLine(FirstInt * SecondInt)

            Catch ex As Exception

                Console.WriteLine("Overflow")

            End Try

            Console.WriteLine("Again? y/N")
            YN = Console.ReadLine()

            If YN = "y" Then

                Main()

            Else

                Console.WriteLine("Sure Want to exit?(Press Enter Again To Exit!)")
                YN = Console.ReadLine()

                If YN = "n" Then

                    Main()

                Else

                End If
            End If
        ElseIf Op = "/" Then

            Console.WriteLine("You Expression Will Be: " & FirstInt & " " & "/ " & SecondInt)
            Console.WriteLine("and the result is:")
            Console.WriteLine(FirstInt / SecondInt)
            Console.WriteLine("Again? y/n")
            YN = Console.ReadLine()

            If YN = "y" Then

                Main()

            Else

                Console.WriteLine("Sure Want to exit?(Press Enter Again To Exit!)")
                YN = Console.ReadLine()

                If YN = "n" Then

                    Main()

                Else

                End If

            End If

        Else

            Console.WriteLine("You didin't selected any operator!")
            Console.WriteLine("Again? y/n")
            YN = Console.ReadLine()

            If YN = "y" Then

                Main()

            Else

                Console.WriteLine("Sure Want to exit?(Press Enter Again To Exit!)")
                YN = Console.ReadLine()

                If YN = "n" Then

                    Main()

                Else

                End If

            End If

        End If

    End Sub

End Module
