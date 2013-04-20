Imports System.IO

Public Class FrmMain

    'Specifies Dot Matrix (Grpahixs Area) width
    Const DOT_MATRIX_WIDTH As Integer = 8

    'Specifies the actual used Dot Matrix width
    'Note: Dot Matrix is create based on DOT_MATRIX_WIDTH
    'However, only Actual width is displayed to the user
    'This is done because the byte format is 8 bits, however, the LCD cell is 5 pixels wide only (bit 0..4)
    Const DOT_MATRIX_WIDTH_ACTUAL As Integer = 5
    Const DOT_MATRIX_LENGTH As Integer = 8

    'This is the actual matrix which is displayed in the "Image" Frame, it is basically an array of labels
    Dim DotMatrix(DOT_MATRIX_WIDTH, DOT_MATRIX_LENGTH) As Label
    'And this is a matrix uesd for the "preview", same as the actual but smaller size such that the whole picture can be seen
    Dim DotMatrixDISP(DOT_MATRIX_WIDTH, DOT_MATRIX_LENGTH) As Label

    'These two variables controls the colors used in the backcolor (OFF) and forecolor (ON) pixels
    Dim DISPLAY_BACKCOLOR As Color = Color.LightGray
    Dim DISPLAY_FORECOLOR As Color = Color.Gray



    'Used to store the HEX data on the UpdateHEX() function
    Private HEX_CODES(2, 8) As Char

    'Flag for the status of file saving
    Private FileSavedFlag As Boolean = True

    'Text stored on the begining of the saved *.ccg file to verify the file on opening
    Private Const SaveFileCheckText As String = "#This is a CCG File (Custom Character Generator) File#"








    'This sub creates the Dot Matrix in the "Image" Frame, DOT_MATRIX_WIDTH pixels are created and a "0" is stored on their text fields,
    ' DOT_MATRIX_ACTUAL is initialized and displayed

    Private Sub CreateDotMatrix()

        'The constatns below defines the shape of the area to be drawn

        'The Offset of the first element (Note that the count is started from right to left), such that the LSB is in most right and MSB on left
        Const INITIAL_X_OFFSET As Integer = 150
        Const INITIAL_Y_OFFSET As Integer = 30

        'The offset between the Dots
        Const DOT_X_OFFSET As Integer = 2
        Const DOT_Y_OFFSET As Integer = 2

        'The dimenstions of the Dots
        Const DOT_WIDTH As Integer = 20
        Const DOT_LENGTH As Integer = 20

        'Same as above, but for the "Preview" area
        Const INITIAL_X_OFFSET_DISP As Integer = 70
        Const INITIAL_Y_OFFSET_DISP As Integer = 20
        Const DOT_X_OFFSET_DISP As Integer = 1
        Const DOT_Y_OFFSET_DISP As Integer = 1
        Const DOT_WIDTH_DISP As Integer = 5
        Const DOT_LENGTH_DISP As Integer = 5



        'Create the whole Dot Matricies and write "0" as an initial value
        For i = 0 To DOT_MATRIX_WIDTH - 1

            For j = 0 To DOT_MATRIX_LENGTH - 1

                DotMatrix(i, j) = New Label
                DotMatrixDISP(i, j) = New Label
                DotMatrix(i, j).Text = "0"
            Next

        Next



        'Initialize the Actual Dot Matrix
        For i = 0 To DOT_MATRIX_WIDTH_ACTUAL - 1
            For j = 0 To DOT_MATRIX_LENGTH - 1

                'Add the previously created controls to their respecitve frames
                FraImage.Controls.Add(DotMatrix(i, j))
                FraPreview.Controls.Add(DotMatrixDISP(i, j))
                'Locate them based on the location/dimension constants defined above
                ' Location = Offset - i*width - i*offset
                ' Negative sign because we are starting from right to left due to LSB/MSB compliance
                DotMatrix(i, j).Location = New Point(INITIAL_X_OFFSET - i * DOT_WIDTH - i * DOT_X_OFFSET, INITIAL_Y_OFFSET + j * DOT_LENGTH + j * DOT_Y_OFFSET)
                DotMatrixDISP(i, j).Location = New Point(INITIAL_X_OFFSET_DISP - i * DOT_WIDTH_DISP - i * DOT_X_OFFSET_DISP, INITIAL_Y_OFFSET_DISP + j * DOT_LENGTH_DISP + j * DOT_Y_OFFSET_DISP)
                'Dot Size
                DotMatrix(i, j).Size = New Size(DOT_WIDTH, DOT_LENGTH)
                DotMatrixDISP(i, j).Size = New Size(DOT_WIDTH_DISP, DOT_LENGTH_DISP)
                'Backcolor
                DotMatrix(i, j).BackColor = DISPLAY_BACKCOLOR
                DotMatrixDISP(i, j).BackColor = DISPLAY_BACKCOLOR
                'Text Alignment
                DotMatrix(i, j).TextAlign = ContentAlignment.MiddleCenter

                'Event Handlers for Click Event and TextChanged event
                AddHandler DotMatrix(i, j).Click, AddressOf DrawClickHandler
                AddHandler DotMatrix(i, j).TextChanged, AddressOf DrawChangeHandler

            Next
        Next



    End Sub


    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On Form Load, create the matrices
        CreateDotMatrix()
    End Sub


    'Event handler for TextChanged of the DotMatrix
    Private Sub DrawChangeHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Change the color when text changes, this is used when loading a file
        If sender.text = "0" Then
            sender.backcolor = DISPLAY_BACKCOLOR
        Else
            sender.backcolor = DISPLAY_FORECOLOR
        End If

        'Update the text
        UpdateHEX()


    End Sub

    'Event handler for Click of DotMatrix
    Private Sub DrawClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Toggle state and Change color accordingly
        If sender.text = "0" Then
            sender.text = "1"
            sender.backcolor = DISPLAY_FORECOLOR
        Else
            sender.text = "0"
            sender.backcolor = DISPLAY_BACKCOLOR
        End If


        'Update HEX text
        UpdateHEX()

        'Flag the current file as unsaved
        FileSavedFlag = False


    End Sub


    'This is the function which does the actual conversion from binary to hex
    ' and writes the data to the text field TxtHEX, an 'S' in the TxtHEX indicates error in reading a number
    ' this is called everytime any change is done to update the "Preview" area and the "TxtHEX" data
    Private Sub UpdateHEX()


        TxtHEX.Text = "0x"

        For j = 0 To DOT_MATRIX_LENGTH - 1
            For i = DOT_MATRIX_WIDTH - 1 To 0 Step -4   'Step in 4 to take one HEX at a time, negative is used to read from right to left, remember MSB...LSB

                'Below, combine 4 bits to form one HEX
                Select Case DotMatrix(i, j).Text + DotMatrix(i - 1, j).Text + DotMatrix(i - 2, j).Text + DotMatrix(i - 3, j).Text
                    Case "0000"
                        HEX_CODES(i / 4, j) = "0"

                    Case "0001"
                        HEX_CODES(i / 4, j) = "1"

                    Case "0010"
                        HEX_CODES(i / 4, j) = "2"

                    Case "0011"
                        HEX_CODES(i / 4, j) = "3"

                    Case "0100"
                        HEX_CODES(i / 4, j) = "4"

                    Case "0101"
                        HEX_CODES(i / 4, j) = "5"

                    Case "0110"
                        HEX_CODES(i / 4, j) = "6"

                    Case "0111"
                        HEX_CODES(i / 4, j) = "7"

                    Case "1000"
                        HEX_CODES(i / 4, j) = "8"

                    Case "1001"
                        HEX_CODES(i / 4, j) = "9"

                    Case "1010"
                        HEX_CODES(i / 4, j) = "A"

                    Case "1011"
                        HEX_CODES(i / 4, j) = "B"

                    Case "1100"
                        HEX_CODES(i / 4, j) = "C"

                    Case "1101"
                        HEX_CODES(i / 4, j) = "D"

                    Case "1110"
                        HEX_CODES(i / 4, j) = "E"

                    Case "1111"
                        HEX_CODES(i / 4, j) = "F"

                    Case Else
                        HEX_CODES(i / 4, j) = "S"   'Indicates an ERROR

                End Select

                'Write the data (two HEX letters) on the text field
                TxtHEX.Text = TxtHEX.Text + HEX_CODES(i / 4, j)

            Next

            'Do NOT add "0x" at the end ;)
            If j < DOT_MATRIX_LENGTH - 1 Then
                TxtHEX.Text = TxtHEX.Text + ", 0x"
            End If

        Next


        'Update the "Preview" area
        For j = 0 To DOT_MATRIX_LENGTH - 1
            For i = 0 To DOT_MATRIX_WIDTH - 1
                DotMatrixDISP(i, j).BackColor = DotMatrix(i, j).BackColor
            Next
        Next



    End Sub




    'Button to Copy the contents of TxtHEX to the clipboard
    Private Sub CmdCopyToClipBoard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCopyToClipBoard.Click
        CopyToClipboard()
    End Sub

    'Copy the contents of TxtHEX to the clipboard
    Private Sub CopyToClipboard()
        Clipboard.Clear()
        Clipboard.SetText(TxtHEX.Text)
    End Sub










    'Button to Clear the DotMatrix
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        ClearDisplay()
    End Sub

    'Function which checks weather the file is saved prior to clearing the DotMatrix
    Private Sub ClearDisplay()


        If Not FileSavedFlag Then
            Select Case MsgBox("File has been changed, do you want to save first?", MsgBoxStyle.YesNoCancel, "New File ...")
                'If the users wishes to save, let him do so
                Case MsgBoxResult.Yes
                    SaveFile()
                    DoClearDisplay()
                    'Else, clear


                Case MsgBoxResult.No
                    DoClearDisplay()


                    'Or cancel it all together
                Case MsgBoxResult.Cancel
                    'do nothing if cancel

            End Select

        Else
            'If file is saved, do clear the display
            DoClearDisplay()
        End If
        
    End Sub


    'Clear Display and update the TxtHEX data
    Private Sub DoClearDisplay()
        For j = 0 To DOT_MATRIX_LENGTH - 1
            For i = 0 To DOT_MATRIX_WIDTH - 1
                DotMatrix(i, j).BackColor = DISPLAY_BACKCOLOR
                DotMatrix(i, j).Text = "0"
                DotMatrixDISP(i, j).BackColor = DISPLAY_BACKCOLOR
            Next
        Next
        UpdateHEX()
    End Sub






    'Fill the Display (in case you need an inverted image)
    Private Sub CmdFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFill.Click
        FillDisplay()
    End Sub

    Private Sub FillDisplay()
        For j = 0 To DOT_MATRIX_LENGTH - 1
            For i = 0 To DOT_MATRIX_WIDTH - 1
                DotMatrix(i, j).BackColor = DISPLAY_FORECOLOR
                DotMatrix(i, j).Text = "1"
                DotMatrixDISP(i, j).BackColor = DISPLAY_FORECOLOR
            Next
        Next
        UpdateHEX()
    End Sub




    'For Fun secret Part ;)
    Dim secretCNTR As Integer = 0
    Private Sub LblSecret_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSecret.Click
        TmrSecret.Enabled = True
        secretCNTR += 1
        If secretCNTR = 10 Then
            MsgBox("This Program is Written by MUAZ SALAH, April 2012", vbOK + vbCritical, "Its mine :)")
        End If
    End Sub

    Private Sub TmrSecret_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrSecret.Tick
        secretCNTR = 0
        TmrSecret.Enabled = False
    End Sub













    'Menus
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        ClearDisplay()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile()
    End Sub

    Private Sub CopyHEXToClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyHEXToClipboardToolStripMenuItem.Click
        CopyToClipboard()
    End Sub

    Private Sub ClearDisplayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDisplayToolStripMenuItem.Click
        ClearDisplay()
    End Sub

    Private Sub FillDisplayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillDisplayToolStripMenuItem.Click
        FillDisplay()
    End Sub


    'Sub to Save File
    Private Sub SaveFile()

        'Navigate to the previous directory if any
        If FileSavedFlag Then
            DlgSaveFile.InitialDirectory = DlgOpenFile.FileName
        End If

        'Open Save File dialog
        If DlgSaveFile.ShowDialog() = DialogResult.OK Then
            'Create a stream to save the data
            Dim myStream As New StreamWriter(DlgSaveFile.FileName, False)
            'Write the verification sentence
            myStream.WriteLine(SaveFileCheckText)
            'Write the data from DotMatrix to the stream
            For j = 0 To DOT_MATRIX_LENGTH - 1
                For i = DOT_MATRIX_WIDTH - 1 To 0 Step -1
                    myStream.Write(DotMatrix(i, j).Text)
                Next
            Next
            'Close the stream
            myStream.Close()
        End If

        'Display purpose
        StsLblName.Text = DlgSaveFile.FileName
        'Change the state of file saving
        FileSavedFlag = True
    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click

        Dim ImportedData As String

        If FileSavedFlag Then
            DlgOpenFile.InitialDirectory = DlgSaveFile.FileName
        End If

        If DlgOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim myReader As New StreamReader(DlgOpenFile.FileName)

            ImportedData = myReader.ReadLine

            If ImportedData.StartsWith(SaveFileCheckText) Then

                For j = 0 To DOT_MATRIX_LENGTH - 1
                    For i = DOT_MATRIX_WIDTH - 1 To 0 Step -1
                        'Read the data to the DotMatrix converting it from ASCII to char
                        DotMatrix(i, j).Text = ChrW(myReader.Read)
                    Next
                Next
                myReader.Close()

                StsLblName.Text = DlgOpenFile.FileName

            Else
                'If verification sentence does not exist:
                MsgBox("File is not correct", MsgBoxStyle.Critical, "Error")
            End If

        End If


    End Sub



End Class
