Imports DevExpress.Utils
Imports DevExpress.XtraEditors.CustomEditor
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication202
	Public NotInheritable Class ImageSliderHelper

		Private Sub New()
		End Sub

		Private Shared currentImageIndex As Integer = 0
		Private Shared currentCollection As ImageCollection = Nothing
		Private Shared view As GridView = Nothing
		Private Shared images() As ImageCollection = Nothing

		Public Shared Sub BindImageSlider(ByVal grid As GridControl, ByVal columnFieldName As String, ParamArray ByVal rowImages() As ImageCollection)
			images = rowImages
			Dim repository As New RepositoryItemAnyControl()
			grid.RepositoryItems.Add(repository)
			Dim slider As New MyImageSlider()
			view = TryCast(grid.MainView, GridView)
			repository.Control = slider
			view.Columns("Image").ColumnEdit = repository
			view.Columns("Description").OptionsColumn.AllowEdit = False
			view.RowHeight = slider.Size.Height
			AddHandler view.ShownEditor, AddressOf view_ShownEditor
		End Sub

		Private Shared Sub view_ShownEditor(ByVal sender As Object, ByVal e As EventArgs)
			Dim view As GridView = TryCast(sender, GridView)
			Dim edit As AnyControlEdit = TryCast(view.ActiveEditor, AnyControlEdit)
			If edit IsNot Nothing Then
				currentCollection = images(view.FocusedRowHandle)
				Dim slider As MyImageSlider = TryCast(edit.Properties.Control, MyImageSlider)
				slider.VirtualMode = True
				AddHandler slider.GetImage, AddressOf slider_GetImage
				AddHandler slider.CanGetNextPrevImage, AddressOf slider_CanGetNextPrevImage
				slider.UpdateImage()
				currentImageIndex = 0
			End If
		End Sub

		Private Shared Sub slider_CanGetNextPrevImage(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.CanGetNextPrevImageEventArgs)
			If e.IsNext Then
				e.CanGetImage = (currentImageIndex < currentCollection.Images.Count - 1)
			Else
				e.CanGetImage = (currentImageIndex > 0)
			End If
		End Sub

		Private Shared Sub slider_GetImage(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.GetImageEventArgs)
			If currentCollection IsNot Nothing Then
				If e.IsStartUp Then
					e.Image = currentCollection.Images(0)
					Return
				End If
				If e.IsNext Then
					e.Image = currentCollection.Images(currentImageIndex + 1)
					If e.CurrentImageUpdated Then
						currentImageIndex += 1
					End If
				ElseIf e.IsPrev Then
					e.Image = currentCollection.Images(currentImageIndex - 1)
					If e.CurrentImageUpdated Then
						currentImageIndex -= 1
					End If
				End If
			End If
		End Sub
	End Class
End Namespace
