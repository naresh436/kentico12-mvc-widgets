﻿using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.Collections.Generic;

namespace Kentico.MVC.Widgets
{
    public class EditableImageWidgetProperties: IWidgetProperties
    {
        [EditingComponent(MediaFilesSelector.IDENTIFIER, Order = 0)]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        public IList<MediaFilesSelectorItem> Image { get; set; }


        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 1)]
        [EditingComponentProperty("Label", "Height")]
        public int Height { get; set; }

        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 2)]
        [EditingComponentProperty("Label", "Width")]
        public int Width { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3)]
        [EditingComponentProperty("Label", "Alternate Text")]
        public string AlternateText { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4)]
        [EditingComponentProperty("Label", "Image CSS Class")]
        public string ImagClass { get; set; }


        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 5)]
        [EditingComponentProperty("Label", "Render as Link")]
        public bool ShowImageAsLink { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 6)]
        [EditingComponentProperty("Label", "Redirection URL")]
        public string RedirectionURL { get; set; }


        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 7)]
        [EditingComponentProperty("Label", "Link CSS Class")]
        public string LinkClass { get; set; }


    }
}
