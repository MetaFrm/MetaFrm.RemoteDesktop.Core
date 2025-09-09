using System.Drawing;

namespace MetaFrm.RemoteDesktop.Core.Models
{
    /// <summary>
    /// ServerTmp
    /// </summary>
    public class ServerTmp
    {
        /// <summary>
        /// ServerID
        /// </summary>
        public int ServerID { get; set; }
        /// <summary>
        /// IsSmartSizing
        /// </summary>
        public bool IsSmartSizing { get; set; }
        /// <summary>
        /// IsFullScreen
        /// </summary>
        public bool IsFullScreen { get; set; }
        /// <summary>
        /// IsUseMultimon
        /// </summary>
        public bool IsUseMultimon { get; set; }

        /// <summary>
        /// DesktopWidth(실제 데스크톱 넓이)
        /// </summary>
        public int DesktopWidth { get; set; }
        /// <summary>
        /// ControlHeight(실제 데스크톱 높이)
        /// </summary>
        public int DesktopHeight { get; set; }
        /// <summary>
        /// ControlWidth(실제 뷰 넓이)
        /// </summary>
        public int ControlWidth { get; set; }
        /// <summary>
        /// ControlHeight(실제 뷰 높이)
        /// </summary>
        public int ControlHeight { get; set; }

        /// <summary>
        /// ControlX
        /// </summary>
        public int ControlX { get; set; }
        /// <summary>
        /// ControlY
        /// </summary>
        public int ControlY { get; set; }

        /// <summary>
        /// ScreenBounds
        /// </summary>
        public Rectangle? ScreenBounds { get; set; } = null;
    }
}