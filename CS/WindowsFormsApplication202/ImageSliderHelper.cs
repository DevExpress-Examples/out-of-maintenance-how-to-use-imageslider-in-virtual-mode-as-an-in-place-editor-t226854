using DevExpress.Utils;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication202 {
    static public class ImageSliderHelper {
        static int currentImageIndex = 0;
        static ImageCollection currentCollection = null;
        static GridView view = null;
        static ImageCollection[] images = null;

        public static void BindImageSlider(GridControl grid, string columnFieldName, params ImageCollection[] rowImages) {
            images = rowImages;
            RepositoryItemAnyControl repository = new RepositoryItemAnyControl();
            grid.RepositoryItems.Add(repository);
            MyImageSlider slider = new MyImageSlider();
            view = grid.MainView as GridView;
            repository.Control = slider;
            view.Columns["Image"].ColumnEdit = repository;
            view.Columns["Description"].OptionsColumn.AllowEdit = false;
            view.RowHeight = slider.Size.Height;
            view.ShownEditor += view_ShownEditor;
        }

        private static void view_ShownEditor(object sender, EventArgs e) {
            GridView view = sender as GridView;
            AnyControlEdit edit = view.ActiveEditor as AnyControlEdit;
            if (edit != null) {
                currentCollection = images[view.FocusedRowHandle];
                MyImageSlider slider = edit.Properties.Control as MyImageSlider;
                slider.VirtualMode = true;
                slider.GetImage += slider_GetImage;
                slider.CanGetNextPrevImage += slider_CanGetNextPrevImage;
                slider.UpdateImage();
                currentImageIndex = 0;
            }
        }

        static void slider_CanGetNextPrevImage(object sender, DevExpress.XtraEditors.Controls.CanGetNextPrevImageEventArgs e) {
            if (e.IsNext) e.CanGetImage = (currentImageIndex < currentCollection.Images.Count - 1);
            else e.CanGetImage = (currentImageIndex > 0);
        }

        static void slider_GetImage(object sender, DevExpress.XtraEditors.Controls.GetImageEventArgs e) {
            if (currentCollection != null) {
                if (e.IsStartUp) {
                    e.Image = currentCollection.Images[0];
                    return;
                }
                if (e.IsNext) {
                    e.Image = currentCollection.Images[currentImageIndex + 1];
                    if (e.CurrentImageUpdated) ++currentImageIndex;
                }
                else if (e.IsPrev) {
                    e.Image = currentCollection.Images[currentImageIndex - 1];
                    if (e.CurrentImageUpdated) --currentImageIndex;
                }
            }
        }
    }
}
