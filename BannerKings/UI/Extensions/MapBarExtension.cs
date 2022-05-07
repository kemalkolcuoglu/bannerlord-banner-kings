﻿using Bannerlord.UIExtenderEx.Attributes;
using Bannerlord.UIExtenderEx.Prefabs2;
using System.Collections.Generic;
using System.Xml;

namespace BannerKings.UI.Extensions
{

    [PrefabExtension("MapBar", "descendant::ListPanel[@Id='TopInfoBar']/Children", "MapBar")]
    internal class MapBarExtension : PrefabExtensionInsertPatch
    {
        public override InsertType Type => InsertType.Child;
        public override int Index => 1;

        private List<XmlNode> nodes;

        public MapBarExtension()
        {
            XmlDocument firstChild = new XmlDocument();
            firstChild.LoadXml("<HintWidget DataSource=\"{PietyHint}\" WidthSizePolicy=\"CoverChildren\" HeightSizePolicy=\"CoverChildren\" VerticalAlignment=\"Center\" Command.HoverBegin=\"ExecuteBeginHint\" Command.HoverEnd=\"ExecuteEndHint\"><Children><ListPanel WidthSizePolicy=\"CoverChildren\" HeightSizePolicy=\"CoverChildren\" IsEnabled=\"false\"><Children><Widget WidthSizePolicy=\"Fixed\" HeightSizePolicy=\"Fixed\" SuggestedWidth=\"18\" SuggestedHeight=\"33\" VerticalAlignment=\"Center\"><Children><Widget WidthSizePolicy=\"Fixed\" HeightSizePolicy=\"Fixed\" SuggestedWidth=\"33\" SuggestedHeight=\"33\" HorizontalAlignment=\"Center\" VerticalAlignment=\"Center\" Sprite=\"General\\Icons\\Prosperity\" /></Children></Widget><MapBarCustomValueTextWidget DataSource=\"{..}\" WidthSizePolicy=\"CoverChildren\" HeightSizePolicy=\"Fixed\" MinWidth=\"20\" MaxWidth=\"55\" SuggestedHeight=\"50\" VerticalAlignment=\"Center\" PositionYOffset=\"2\" MarginLeft=\"2\" Brush=\"MapTextBrushWithAnim\" Brush.FontSize=\"20\" IsWarning=\"@IsInfluenceTooltipWarning\" NormalColor=\"!NormalMapBarTextColor\" Text=\"@PietyWithAbbrText\" ValueAsInt=\"@Piety\" WarningColor=\"!WarningMapBarTextColor\" /></Children></ListPanel></Children></HintWidget>");

            nodes = new List<XmlNode> { firstChild };
        }

        [PrefabExtensionXmlNodes]
        public IEnumerable<XmlNode> Nodes => nodes;
        
    }
}
