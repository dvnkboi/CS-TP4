using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNotes.utils
{
    class MenuStripRenderer : ToolStripProfessionalRenderer
    {
        public MenuStripRenderer() : base(new BrowserColors()) { }
    }

    public class BrowserColors : ProfessionalColorTable
    {
        public override Color MenuStripGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color MenuItemSelected { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color MenuItemBorder { get { return Color.FromArgb(0, Color.Transparent); } }
        public override Color MenuBorder { get { return Color.FromArgb(0, Color.Transparent); } }
        public override Color MenuItemSelectedGradientBegin { get { return Color.FromArgb(128,40, 40, 40); } }
        public override Color MenuItemSelectedGradientEnd { get { return Color.FromArgb(128,40, 40, 40); } }
        public override Color MenuItemPressedGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color MenuItemPressedGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color MenuItemPressedGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color RaftingContainerGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color RaftingContainerGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color SeparatorDark { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color SeparatorLight { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color StatusStripGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color StatusStripGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripBorder { get { return Color.FromArgb(0, Color.Transparent); } }
        public override Color ToolStripDropDownBackground { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripContentPanelGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripContentPanelGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripPanelGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ToolStripPanelGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color OverflowButtonGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color MenuStripGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ImageMarginRevealedGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ImageMarginRevealedGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ImageMarginRevealedGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonSelectedHighlight { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonSelectedHighlightBorder { get { return Color.FromArgb(0, Color.Transparent); } }
        public override Color ButtonPressedHighlight { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonPressedHighlightBorder { get { return Color.FromArgb(0, Color.Transparent); } }
        public override Color ButtonCheckedHighlight { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonCheckedHighlightBorder { get { return Color.FromArgb(0, Color.Transparent); } }
        public override Color ButtonPressedBorder { get { return Color.FromArgb(0, Color.Transparent); } }  
        public override Color ButtonSelectedBorder { get { return Color.FromArgb(0, Color.Transparent); } }
        public override Color ButtonCheckedGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonCheckedGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonCheckedGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color OverflowButtonGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonSelectedGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonSelectedGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonPressedGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonPressedGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonPressedGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color CheckBackground { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color CheckSelectedBackground { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color CheckPressedBackground { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color GripDark { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color GripLight { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ImageMarginGradientBegin { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ImageMarginGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ImageMarginGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color ButtonSelectedGradientMiddle { get { return Color.FromArgb(100, 150, 150, 150); } }
        public override Color OverflowButtonGradientEnd { get { return Color.FromArgb(100, 150, 150, 150); } }

    }
}
