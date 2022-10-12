' Name:         Minecraft Stack Splitter
' Purpose:      To split a number into groups of 64 or 16 and a remainder
' Programmer:   Joshua Steege on 2/9/2020

Option Explicit On
Option Infer Off

Public Class MainForm

    ' Declare Global Variables
    Dim intStackSize As Integer = 64
    Dim intStacks As Integer
    Dim intItems As Integer
    Dim intCount As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Using txtItemInput and the radio buttons, calculates and removed the remainder from the count
        Integer.TryParse(txtItemInput.Text, intCount)

        ' items = count % stackSize
        intItems = intCount Mod intStackSize
        intCount = intCount - intItems

        ' Takes the remaining count and divides by the stack size gotten from radio buttons
        intStacks = intCount / intStackSize

        ' Formats text for proper grammer
        If intItems = 1 Then
            lblItemsOutputContext.Text = "item."
        Else
            lblItemsOutputContext.Text = "items."
        End If

        If intStacks = 1 Then
            lblStacksOutputContext.Text = "stack and"
        Else
            lblStacksOutputContext.Text = "stacks and"
        End If

        ' Writes results to the respective labels (lblStackCount and lblItemCount)
        lblItemCount.Text = intItems.ToString
        lblStackCount.Text = intStacks.ToString

        txtItemInput.Text = String.Empty

    End Sub

    Private Sub btn64Stack_Click(sender As Object, e As EventArgs) Handles btn64Stack.Click

        ' Change stack size to 64
        intStackSize = 64

    End Sub

    Private Sub btn16Stack_Click(sender As Object, e As EventArgs) Handles btn16Stack.Click

        ' Change stack size to 16
        intStackSize = 16

    End Sub

    Private Sub txtItemInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemInput.KeyPress

        ' Accept only numbers and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub
End Class
