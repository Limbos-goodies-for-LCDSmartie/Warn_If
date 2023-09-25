
'
'      ===  Demo LCDSmartie Plugin for vb.net  ===
'
' dot net plugins are supported in LCD Smartie 5.3 beta 3 and above.
'

' There must be a public Class that's named LCDSmartie





Imports System.Text

Public Class LCDSmartie

    ' This function is used in LCDSmartie by using the dll command as follows:
    '    $dll(vbdotnetplugin,2,hello,there)
    ' Smartie will then display on the LCD: Not implemented
    Public Function function1(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "about" Then
            Return "  returns warning first value is greater than second"

        Else

            Dim Parts = Split(param1, "/")

            If Parts(0) > Parts(1) Then
                Return param2
            Else
                Return Parts(0)
            End If


        End If

    End Function
    ' This function is used in LCDSmartie by using the dll command as follows:
    '    $dll(vbdotnetplugin,1,hello,there)
    ' Smartie will then display on the LCD: function called with (hello, there)
    Public Function function2(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "about" Then
            Return "  returns warning first value is smaller than second"

        Else

            Dim Parts = Split(param1, "/")

            If Parts(0) < Parts(1) Then
                Return param2
            Else
                Return Parts(0)
            End If


        End If





    End Function

    Public Function function3(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "about" Then
            Return "  returns warning if to values are equal"

        Else

            Dim Parts = Split(param1, "/")

            If Parts(0) = Parts(1) Then
                Return param2
            Else
                Return Parts(0)
            End If


        End If




    End Function

    Public Function function4(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "about" Then
            Return "  returns warning if to values are different"

        Else

            Dim Parts = Split(param1, "/")

            If Parts(0) <> Parts(1) Then
                Return param2
            Else
                Return Parts(0)
            End If


        End If




    End Function





    Public Function function11(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "about" Then
            Return "  returns warning first value is greater or equal than second"

        Else

            Dim Parts = Split(param1, "/")

            If Parts(0) >= Parts(1) Then
                Return param2
            Else
                Return Parts(0)
            End If


        End If

    End Function
    ' This function is used in LCDSmartie by using the dll command as follows:
    '    $dll(vbdotnetplugin,1,hello,there)
    ' Smartie will then display on the LCD: function called with (hello, there)
    Public Function function12(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "about" Then
            Return "  returns warning first value is smaller or equal  than second"

        Else

            Dim Parts = Split(param1, "/")

            If Parts(0) <= Parts(1) Then
                Return param2
            Else
                Return Parts(0)
            End If


        End If

    End Function





    Public Function function20(ByVal param1 As String, ByVal param2 As String) As String

        If param1 = "about" Or param2 = "about" Then
            Return "  Created by Nikos Georgousis"

        Else
            Return " warnif.dll version 1.1 by Limbo"

        End If

    End Function



    Public Function SmartieInfo()

        Return "Developer:Nikos Georgousis (Limbo)" & vbNewLine & "Version:1.1"

    End Function

    Public Function SmartieDemo()
        Dim demolist As New StringBuilder()

        demolist.AppendLine("warnif plugin for LCD Smartie")
        demolist.AppendLine("This plugin displays a message if a condition is true, otherwise the value is displayed. ")
        demolist.AppendLine("It is useful to display warning messages when a temperature is high or on any other critical value received.")
        demolist.AppendLine("")
        demolist.AppendLine("The two values to be compared should be passed under the first parameter separated by '/' ")
        demolist.AppendLine("e.g.    $dll(warnif,1,20/35, This is a high value warning )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function1 ------")
        demolist.AppendLine(">>>  Returns warning first value is greater than second <<<")
        demolist.AppendLine(" Greater Warning:  $dll(warnif,1,1250/50, Greater )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function2 ------")
        demolist.AppendLine(">>>  Returns warning first value is smaller than second <<<")
        demolist.AppendLine(" Smaller Warning:  $dll(warnif,2,12/5555,Smaller )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function3 ------")
        demolist.AppendLine(">>>  Returns warning if to values are equal <<<")
        demolist.AppendLine("Equal Warning:  $dll(warnif,3,159/159,Equal )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function4 ------")
        demolist.AppendLine(">>>  Returns warning if to values are different <<<")
        demolist.AppendLine("Different Warning:  $dll(warnif,4,4587/2,Different )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function11 ------")
        demolist.AppendLine(">>>  Returns warning first value is greater or equal than second <<<")
        demolist.AppendLine("Greater-Equal Warning:  $dll(warnif,11,9457/9457,Greater or Equal)")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function12 ------")
        demolist.AppendLine(">>>  Returns warning first value is smaller or equal  than second <<<")
        demolist.AppendLine(" Smaller-Equal Warning :  $dll(warnif,12,4/4,Smaller or Equal )")
        demolist.AppendLine("")
        demolist.AppendLine("------ Function20 ------")
        demolist.AppendLine(">>>  Returns Credits <<<")
        demolist.AppendLine("")
        demolist.AppendLine("------------------------------------------------------------------------------------------------------------------")
        demolist.AppendLine(" *** Visit ***")
        demolist.AppendLine("> Home page")
        demolist.AppendLine("https://lcdsmartie.sourceforge.net")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> Active development branch (latest version)")
        demolist.AppendLine("https://github.com/stokie-ant/lcdsmartie-laz")
        demolist.AppendLine("")

        Dim result As String = demolist.ToString()
        Return result
    End Function




End Class