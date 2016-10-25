Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("rundll32 printui.dll PrintUIEntry /in /n \\nexfileserverb\NEX1_FrtOffice_Canon_C5235")
        End If
        If CheckBox2.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("rundll32 printui.dll PrintUIEntry /in /n \\nexfileserverb\NEX1_FrtOffice_Canon_Plotter")
        End If
        If CheckBox3.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("rundll32 printui.dll PrintUIEntry /in /n \\nexfileserverb\NEX2_BulkOffice_Canon_C3325")
        End If
        If CheckBox4.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("rundll32 printui.dll PrintUIEntry /in /n \\nexfileserverb\NEX3_PLS_Canon_C2225")
        End If
        If CheckBox5.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("rundll32 printui.dll PrintUIEntry /in /n \\nexfileserverb\MAP_Office_HP_M551")
        End If
        If CheckBox6.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("rundll32 printui.dll PrintUIEntry /in /n \\nexfileserverb\ELP_Office_Canon_C2020")
        End If
        If CheckBox7.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("")
        End If
        If CheckBox8.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("")
        End If
        If CheckBox9.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("")
        End If
        If CheckBox10.Checked = True Then
            Dim OpenCMD = CreateObject("wscript.shell")
            OpenCMD.run("")
        End If
        MsgBox("Installation is complete!")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
