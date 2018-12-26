using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace x1
{
    public partial class Main : Form
    {
        #region epic dLLimportz
        /// <summary>
        /// Most of this is from pinvoke.net lol
        /// </summary>
        /// <returns></returns>

        [DllImport("user32.dll")]
        static extern IntPtr GetShellWindow();

        [DllImport("user32.dll", SetLastError = false)]
        static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern ushort GetAsyncKeyState(int vKey);

        public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey)
        {
            return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);


        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);


        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private static IntPtr m_hTaskBar;

        public static void HideTaskBar()
        {
            m_hTaskBar = FindWindow("Shell_TrayWnd", null);

            if ((int)m_hTaskBar != 0)
            {
                ShowWindow(m_hTaskBar, 0);
            }
        }
        #endregion

        public Main()
        {
            InitializeComponent();
        }

        bool helpdialog = false;
        PowerStatus battery = SystemInformation.PowerStatus;
        Help help = new Help();
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        private void Main_Load(object sender, EventArgs e)
        {


            SetProcessDPIAware();

            if (File.Exists(appdata + "/x1left"))
            {
                Width = 62;
                spotifytrack.Anchor = AnchorStyles.Right;
                seperator.Anchor = AnchorStyles.Right;
                btry.Anchor = AnchorStyles.Right;
                time.Anchor = AnchorStyles.Right;
                panel_StuffHere.Anchor = AnchorStyles.Right;

                Height = Screen.PrimaryScreen.Bounds.Height;
            }
            else
            {
                spotifytrack.Anchor = AnchorStyles.Right;
                seperator.Anchor = AnchorStyles.Right;
                btry.Anchor = AnchorStyles.Right;
                time.Anchor = AnchorStyles.Right;
                panel_StuffHere.Anchor = AnchorStyles.Right;

                Width = Screen.PrimaryScreen.Bounds.Width;
            }

            t1.Start();

            HideTaskBar();

            CheckBattery();

        }

        void CheckBattery()
        {
            int batterynumber = Convert.ToInt32(battery.BatteryLifePercent.ToString("P0").Trim(new Char[] { '%' }));
            if (battery.BatteryChargeStatus.ToString() != "NoSystemBattery")
            {
                if (batterynumber <= 100 && batterynumber >= 80)
                {
                    btry.Text = "[----]";
                }

                if (batterynumber <= 80 && batterynumber >= 70)
                {
                    btry.Text = "[--- ]";
                }

                if (batterynumber <= 70 && batterynumber >= 50)
                {
                    btry.Text = "[--  ]";
                }

                if (batterynumber <= 50 && batterynumber >= 20)
                {
                    btry.Text = "[-   ]";
                }

                if (batterynumber <= 20 && batterynumber >= 0)
                {
                    btry.Text = "[    ]";
                }

            }
            else
            {
                spotifytrack.Location = new Point(98, 10);
                btry.Hide();
                p_Media.Location = new Point(366, 6);
            }
        }

        public string GetSpotifyTrackInfo()
        {
            var proc = Process.GetProcessesByName("Spotify").FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.MainWindowTitle));

            if (proc == null)
                return "";

            if (string.Equals(proc.MainWindowTitle, "Spotify", StringComparison.InvariantCultureIgnoreCase))
                return "       Paused";

            return proc.MainWindowTitle;
        }

        bool IsOnDesktop()
        {
            Process[] proc = Process.GetProcesses();
            IntPtr current = GetForegroundWindow();

            foreach (Process x in proc)
            {
                if (x.MainWindowHandle == current)
                {
                    return false;
                }
            }
            return true;
        }

        #region haha im epic
        private void t1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(appdata + "/x1left"))
            {
                // idfk how to do it its hard man please make a pull request thanks
                Location = new Point(0, 0);
            }

            if (File.Exists(appdata + "/x1top"))
            {
                Location = new Point(0, 0);
            }
            else
            {
                if (!File.Exists(appdata + "/x1left"))
                {
                    var ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
                    Location = new Point(0, ScreenHeight - 40);
                }
            }


            Rectangle window = new Rectangle();
            Rectangle edited = new Rectangle();
            GetWindowRect(GetForegroundWindow(), out window);

            edited.Width = window.Width - window.X;
            edited.Height = window.Height - window.Y;

            //totally not for debugging
            //label1.Text = Convert.ToString(edited.Width) + "E" + Convert.ToString(edited.Height) + " " + Convert.ToString(window.Height) + "W" + Convert.ToString(window.Height) + " " + Convert.ToString(window.X) + "X" + Convert.ToString(window.Y);
            //label1.Text = Convert.ToString(GetForegroundWindow());
            //label1.Text = Convert.ToString(GetDesktopWindow());

            //this is so fucking retarded that i dont even know why it doesnt work only if i add a retarded bool that checks every process this is anoying. install gentoo

            if (edited.Height >= Screen.PrimaryScreen.Bounds.Height && edited.Width >= Screen.PrimaryScreen.Bounds.Width && GetActiveWindowTitle() != "" && GetForegroundWindow() != null && GetForegroundWindow() != GetShellWindow() && GetForegroundWindow() != GetDesktopWindow() && !IsOnDesktop())
            {
                Hide();
            }
            else
            {
                Show();
            }

            if (battery.BatteryChargeStatus.ToString() != "NoSystemBattery")
                CheckBattery();

            title.Text = GetActiveWindowTitle();
            time.Text = DateTime.Now.ToString("HH:mm");

            if (IsKeyPushedDown(Keys.F7) && helpdialog == false)
            {
                help.Show();
                helpdialog = true;
            }

            if (IsKeyPushedDown(Keys.F8) && helpdialog == true)
            {
                helpdialog = false;
                help.Hide();
            }

            if (IsKeyPushedDown(Keys.CapsLock))
            {
                if (IsKeyLocked(Keys.CapsLock))
                {
                    nt1.ShowBalloonTip(5, "x1", "capslock enabled", ToolTipIcon.None);
                }
                else
                {
                    nt1.ShowBalloonTip(5, "x1", "capslock disabled", ToolTipIcon.None);
                }
            }

            Process[] spotify = Process.GetProcessesByName("Spotify");

            if (spotify.Length == 0)
            {
                p_Media.Visible = false;
                spotifytrack.Visible = false;
            }
            else
            {
                spotifytrack.Text = GetSpotifyTrackInfo();
                spotifytrack.Visible = true;
                p_Media.Visible = true;
            }

        }
        #endregion

        private void p_Forward_Click(object sender, EventArgs e)
        {
            var KEYEVENTF_KEYUP = 0x0002;
            var mediaNextTrack = (byte)Keys.MediaNextTrack;
            keybd_event(mediaNextTrack, mediaNextTrack, 0, 0);
            keybd_event(mediaNextTrack, mediaNextTrack, KEYEVENTF_KEYUP, 0);
        }

        private void p_Back_Click(object sender, EventArgs e)
        {
            var KEYEVENTF_KEYUP = 0x0002;
            var mediaPreviousTrack = (byte)Keys.MediaPreviousTrack;
            keybd_event(mediaPreviousTrack, mediaPreviousTrack, 0, 0);
            keybd_event(mediaPreviousTrack, mediaPreviousTrack, KEYEVENTF_KEYUP, 0);
        }

        private void btry_MouseHover(object sender, EventArgs e)
        {
            ttp.Show(battery.BatteryLifePercent.ToString("P0"), btry);
        }
    }
}