<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632245/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T226854)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/WindowsFormsApplication202/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication202/Form1.vb))**
* [ImageSliderHelper.cs](./CS/WindowsFormsApplication202/ImageSliderHelper.cs) (VB: [ImageSliderHelper.vb](./VB/WindowsFormsApplication202/ImageSliderHelper.vb))
* [MyImageSlider.cs](./CS/WindowsFormsApplication202/MyImageSlider.cs) (VB: [MyImageSlider.vb](./VB/WindowsFormsApplication202/MyImageSlider.vb))
<!-- default file list end -->
# How to use ImageSlider in Virtual Mode as an in-place editor


<p>This example demonstrates how to use <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument12364">ImageSlider</a> in <strong>Virtual Mode</strong> as <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGridGridControltopic">GridControl</a>'s in-place editor using the IAnyControlEdit interface. <strong>Virtual Mode</strong> is used to upload dynamic images. The main idea is to handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsControlsImageSlider_GetImagetopic">ImageSlider.GetImage</a> and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsControlsImageSlider_CanGetNextPrevImagetopic">ImageSlider.CanGetNextPrevImage</a> events. Handling these events will allow you to pass required images to the control. In other words, you can add required images to your ImageSlider, which should be shown after pressing the Next/Prev buttons. Please refer to the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument12365">Virtual Mode</a> help article for more information.<br />This approach can be applied to <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraTreeListTreeListtopic">TreeList</a> as well.<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-imageslider-in-virtual-mode-as-an-in-place-editor-t226854/14.2.3+/media/60d58d4e-dcf4-11e4-80bf-00155d62480c.png"><br /><br /><strong>See also:</strong><br /><a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsCustomEditorRepositoryItemAnyControltopic">RepositoryItemAnyControl Class</a></p>

<br/>


