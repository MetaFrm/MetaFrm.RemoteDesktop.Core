using MetaFrm.Control;
using System.Drawing;

namespace MetaFrm.RemoteDesktop.Core.Models
{
    /// <summary>
    /// ServerExtend
    /// </summary>
    public class ServerExtend : Server, IAction
    {
        private MetaFrmEventHandler? Action;

        event MetaFrmEventHandler? IAction.Action
        {
            add
            {
                try
                {
                    this.Action -= value;
                }
                catch (Exception)
                {
                }

                this.Action += value;
            }
            remove
            {
                this.Action -= value;
            }
        }

        /// <summary>
        /// DoAction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoAction(ICore sender, MetaFrmEventArgs e)
        {
            this.Action?.Invoke(sender, e);
        }


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

        /// <summary>
        /// IsAdd
        /// </summary>
        public bool IsAdd { get; set; } = false;
        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; } = string.Empty;
        /// <summary>
        /// ConnectedStartTime
        /// </summary>
        public DateTime? ConnectedStartTime { get; set; }
        /// <summary>
        /// IsConnected
        /// </summary>
        public bool IsConnected { get; set; } = false;
    }
}