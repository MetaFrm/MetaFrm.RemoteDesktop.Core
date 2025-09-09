using MetaFrm.Razor.Essentials;

namespace MetaFrm.RemoteDesktop.Core.Models
{
    /// <summary>
    /// Server
    /// </summary>
    public class Server
    {
        /// <summary>
        /// CardWindowStatus
        /// </summary>
        public CardWindowStatus CardWindowStatus { get; set; } = CardWindowStatus.Maximize;

        /// <summary>
        /// SERVER_ID
        /// </summary>
        public int SERVER_ID { get; set; }

        /// <summary>
        /// SERVER_GROUP
        /// </summary>
        public string SERVER_GROUP { get; set; } = string.Empty;

        /// <summary>
        /// SERVER_NAME
        /// </summary>
        public string SERVER_NAME { get; set; } = string.Empty;

        /// <summary>
        /// SERVER
        /// </summary>
        public string SERVER { get; set; } = string.Empty;

        /// <summary>
        /// USER_NAME
        /// </summary>
        public string USER_NAME { get; set; } = string.Empty;

        /// <summary>
        /// USER_ACCESS_NUMBER
        /// </summary>
        public string USER_ACCESS_NUMBER { get; set; } = string.Empty;

        /// <summary>
        /// COLOR_DEPTH
        /// </summary>
        public RemoteDesktop.Core.ColorDepth COLOR_DEPTH { get; set; } = RemoteDesktop.Core.ColorDepth.MaximumColor_32bit;

        /// <summary>
        /// COLOR_DEPTH_DESC
        /// </summary>
        public string COLOR_DEPTH_DESC { get; set; } = string.Empty;

        /// <summary>
        /// IS_SMART_SIZING
        /// </summary>
        public bool IS_SMART_SIZING { get; set; }

        /// <summary>
        /// IS_FULL_SCREEN
        /// </summary>
        public bool IS_FULL_SCREEN { get; set; } = true;

        /// <summary>
        /// IS_USE_MULTIMON
        /// </summary>
        public bool IS_USE_MULTIMON { get; set; }

        /// <summary>
        /// IS_REDIRECT_CLIPBOARD
        /// </summary>
        public bool IS_REDIRECT_CLIPBOARD { get; set; } = true;

        /// <summary>
        /// IS_REDIRECT_DEVICES
        /// </summary>
        public bool IS_REDIRECT_DEVICES { get; set; }

        /// <summary>
        /// IS_REDIRECT_DRIVES
        /// </summary>
        public bool IS_REDIRECT_DRIVES { get; set; }

        /// <summary>
        /// IS_REDIRECT_PORTS
        /// </summary>
        public bool IS_REDIRECT_PORTS { get; set; }

        /// <summary>
        /// IS_REDIRECT_POS_DEVICES
        /// </summary>
        public bool IS_REDIRECT_POS_DEVICES { get; set; }

        /// <summary>
        /// IS_REDIRECT_PRINTERS
        /// </summary>
        public bool IS_REDIRECT_PRINTERS { get; set; }

        /// <summary>
        /// IS_REDIRECT_SMART_CARDS
        /// </summary>
        public bool IS_REDIRECT_SMART_CARDS { get; set; }

        /// <summary>
        /// IS_CONNECT_TO_ADMINISTRATOR_SERVER
        /// </summary>
        public bool IS_CONNECT_TO_ADMINISTRATOR_SERVER { get; set; }

        /// <summary>
        /// IS_KEYBOARD_HOOK_MODE
        /// </summary>
        public bool IS_KEYBOARD_HOOK_MODE { get; set; } = true;

        private int DesktopWidthDic { get; set; } = 1024;
        private int DesktopHeightDic { get; set; } = 768;
        /// <summary>
        /// DESKTOP_SIZE
        /// </summary>
        public string DesktoSize
        {
            get
            {
                return $"{this.DesktopWidthDic}x{this.DesktopHeightDic}";
            }
            set
            {
                if (value.Contains('x'))
                {
                    string[] tmps = value.Split('x');

                    this.DesktopWidthDic = tmps[0].ToInt();
                    this.DesktopHeightDic = tmps[1].ToInt();

                    this.DESKTOP_WIDTH = this.DesktopWidthDic;
                    this.DESKTOP_HEIGHT = this.DesktopHeightDic;
                }
            }
        }

        private int _DESKTOP_WIDTH = 1024;
        /// <summary>
        /// DESKTOP_WIDTH
        /// </summary>
        public int DESKTOP_WIDTH
        {
            get
            {
                return this._DESKTOP_WIDTH;
            }
            set
            {
                this._DESKTOP_WIDTH = value;

                if (this.IsDesktopControlSync)
                    this.CONTROL_WIDTH = this._DESKTOP_WIDTH;
            }
        }

        private int _DESKTOP_HEIGHT = 768;

        /// <summary>
        /// DESKTOP_HEIGHT
        /// </summary>
        public int DESKTOP_HEIGHT
        {
            get
            {
                return this._DESKTOP_HEIGHT;
            }
            set
            {
                this._DESKTOP_HEIGHT = value;

                if (this.IsDesktopControlSync)
                    this.CONTROL_HEIGHT = this._DESKTOP_HEIGHT;
            }
        }

        /// <summary>
        /// CONTROL_WIDTH
        /// </summary>
        public int CONTROL_WIDTH { get; set; } = 640;

        /// <summary>
        /// CONTROL_HEIGHT
        /// </summary>
        public int CONTROL_HEIGHT { get; set; } = 480;


        /// <summary>
        /// IsDesktopControlSync
        /// </summary>
        public bool IsDesktopControlSync { get; set; } = false;
    }
}