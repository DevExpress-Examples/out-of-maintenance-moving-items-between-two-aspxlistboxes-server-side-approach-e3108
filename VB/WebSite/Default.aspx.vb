Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub bntMoveOne_Click(ByVal sender As Object, ByVal e As EventArgs)
		If lbOptions.SelectedItems.Count > 0 Then
			moveItems(lbSelectedOptions, lbOptions)
		End If
	End Sub
	Protected Sub bntReturnOne_Click(ByVal sender As Object, ByVal e As EventArgs)
		If lbSelectedOptions.SelectedItems.Count > 0 Then
			moveItems(lbOptions, lbSelectedOptions)
		End If
	End Sub
	Protected Sub btnMoveAll_Click(ByVal sender As Object, ByVal e As EventArgs)
		lbOptions.SelectAll()
		moveItems(lbSelectedOptions, lbOptions)
	End Sub
	Protected Sub btnReturnAll_Click(ByVal sender As Object, ByVal e As EventArgs)
		lbSelectedOptions.SelectAll()
		moveItems(lbOptions, lbSelectedOptions)
	End Sub
	Private Sub moveItems(ByVal targetlistBox As ASPxListBox, ByVal sourcelistBox As ASPxListBox)
		For i As Integer = 0 To sourcelistBox.SelectedItems.Count - 1
			targetlistBox.Items.Add(sourcelistBox.SelectedItems(i))
		Next i
		targetlistBox.UnselectAll()
		sourcelistBox.UnselectAll()
	End Sub

End Class
