using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBT.Kentico.Xperience.Custom.Widgets.YouTubeVideo
{
    public class YouTubeVideoWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Declaring the widget will visible or not
        /// </summary>
        [CheckBoxComponent(Order = 0, Label = "IsVisible", Tooltip = "Select IsVisible option")]
        public bool IsVisible { get; set; }
        [TextInputComponent(Label = "Video URL", Order = 1, Tooltip = "Enter desired YouTube video URL")]
        public string? VideoURL { get; set; }

        [TextInputComponent(Label = "Width", Order = 2, Tooltip = "Enter desired video width")]
        public string? Width { get; set; }

        [TextInputComponent(Label = "Height", Order = 3, Tooltip = "Enter desired video height")]
        public string? Height { get; set; }


        [CheckBoxComponent(Label = "Related Video", Order = 4, Tooltip = "Select option to enable related videos")]
        public bool IsShowRelatedVideos { get; set; }

        [CheckBoxComponent(Label = "FullScreen", Order = 5, Tooltip = "Select option to enable FullScreen view")]
        public bool IsFullScreen { get; set; }

        [CheckBoxComponent(Label = "Auto Play", Order = 6, Tooltip = "Select option to enable Auto Play")]
        public bool IsAutoPlay { get; set; }
    }
}
