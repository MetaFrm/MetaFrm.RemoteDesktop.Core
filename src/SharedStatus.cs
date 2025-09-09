using System.Drawing;

namespace MetaFrm.RemoteDesktop.Core
{
    /// <summary>
    /// SharedStatus
    /// </summary>
    public class SharedStatus
    {
        /// <summary>
        /// IsFirstLoad
        /// </summary>
        public bool IsFirstLoad { get; set; } = true;

        /// <summary>
        /// SetFirstLoadFalse
        /// </summary>
        public void SetFirstLoadFalse() => IsFirstLoad = false;

        /// <summary>
        /// TopControlOrgLocation
        /// </summary>
        public Point TopControlOrgLocation { get; set; } = new(0, 0);
        /// <summary>
        /// TopControlOrgSize
        /// </summary>
        public Size TopControlOrgSize { get; set; } = new(447, 52);
        /// <summary>
        /// TopControlOrgDockStyle
        /// </summary>
        public int TopControlOrgDockStyle { get; set; } = 1;//DockStyle.Top;


        /// <summary>
        /// BottomControlOrgLocation
        /// </summary>
        public Point BottomControlOrgLocation { get; set; }
        /// <summary>
        /// BottomControlOrgSize
        /// </summary>
        public Size BottomControlOrgSize { get; set; }
        /// <summary>
        /// BottomControlOrgDockStyle
        /// </summary>
        public int BottomControlOrgDockStyle { get; set; }

        /// <summary>
        /// IsTab
        /// </summary>
        public bool IsTab { get; set; }
        /// <summary>
        /// IsMovingLock
        /// </summary>
        public bool IsMovingLock { get; set; }
        /// <summary>
        /// IsResizeLock
        /// </summary>
        public bool IsResizeLock { get; set; }

        /// <summary>
        /// ContainerPanelRightMargin
        /// </summary>
        public int ContainerPanelRightMargin { get; set; } = 20;

        /// <summary>
        /// ResizableUserControlPadding
        /// </summary>
        public int ResizableUserControlPadding { get; set; } = 1;

        /// <summary>
        /// TitleHeightConst
        /// </summary>
        public int TitleHeightConst { get; } = 35;

        /// <summary>
        /// TitleHeight
        /// </summary>
        public bool IsTitleVisible { get; set; } = true;

        /// <summary>
        /// FormWindowState
        /// </summary>
        public int FormWindowState { get; set; }
        /// <summary>
        /// FormLocation
        /// </summary>
        public Point FormLocation { get; set; }
        /// <summary>
        /// FormSize
        /// </summary>
        public Size FormSize { get; set; }



        /// <summary>
        /// FormOrgFormWindowState
        /// </summary>
        public int FormOrgFormWindowState { get; set; }
        /// <summary>
        /// FormOrgLocation
        /// </summary>
        public Point FormOrgLocation { get; set; }
        /// <summary>
        /// FormOrgSize
        /// </summary>
        public Size FormOrgSize { get; set; }

        /// <summary>
        /// Visible_SERVER
        /// </summary>
        public bool Visible_SERVER { get; set; } = true;
        /// <summary>
        /// Visible_USER_NAME
        /// </summary>
        public bool Visible_USER_NAME { get; set; } = true;
    }
}