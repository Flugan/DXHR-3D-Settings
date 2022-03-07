using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DXHR_3D_Settings
{
    public partial class DXHR3D : Form
    {
        private RegistryKey deusEx;
        private RegistryKey deusExDC;
        private RegistryKey deusExReg;
        private float f_monSize = 24;
        private float f_width;
        public DXHR3D()
        {
            InitializeComponent();
        }

        private void DXHR3D_Load(object sender, EventArgs e)
        {
            l_nvDepth.Text = "N/A";
            try
            {
                RegistryKey NV3D = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("NVIDIA Corporation").OpenSubKey("Global").OpenSubKey("Stereo3D");
                int monSize = (int)NV3D.GetValue("MonitorSize");
                l_nvDepth.Text = NV3D.GetValue("StereoSeparation") + "%";
                f_monSize = monSize / (float)2;
                l_monSize.Text = f_monSize.ToString("F1") + "\"";
                deusExDC = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Eidos", true).OpenSubKey("Deus Ex: HRDC", true);
                deusEx = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("Eidos", true).OpenSubKey("Deus Ex: HR", true);
                if (deusExDC != null) {
                    if (deusExDC.GetValue("g_stereoWidth") == null)
                        deusExDC = null;
                }
                if (deusEx != null) {
                    if (deusEx.GetValue("g_stereoWidth") == null)
                        deusEx = null;
                }
                if (deusExDC != null)
                    deusExReg = deusExDC;
                else {
                    deusExReg = deusEx;
                }
                var regValue = (byte[])deusExReg.GetValue("g_stereoWidth");
                f_width = System.BitConverter.ToSingle(regValue, 0);
                int i_width = ((int)Math.Round(10 * f_width) - 10) / 8;
                strengthTracker.Value = i_width;
                strengthChange();

                regValue = (byte[])deusExReg.GetValue("g_stereoPlane");
                float f_plane = System.BitConverter.ToSingle(regValue, 0);
                int i_plane = (int)f_plane / 4;
                planeTracker.Value = i_plane;
                l_plane.Text = f_plane.ToString("F0");
            }
            catch { }
        }

        private void strengthChange()
        {
            l_strength.Text = f_width.ToString("F1");
            float strength = 100 * f_monSize * f_width / 121 / 23;
            l_dxDepth.Text = strength.ToString("F1") + "%";
        }

        private void strengthTracker_Scroll(object sender, EventArgs e)
        {
            int i_width = strengthTracker.Value;
            f_width = (10 + 8 * i_width) / (float)10;
            strengthChange();
            var regValue = System.BitConverter.GetBytes(f_width);
            if (deusEx != null)
                deusEx.SetValue("g_stereoWidth", regValue);
            if (deusExDC != null)
                deusExDC.SetValue("g_stereoWidth", regValue);
        }

        private void planeTracker_Scroll(object sender, EventArgs e)
        {
            int i_plane = planeTracker.Value;
            float f_plane = (float)4 * i_plane;
            l_plane.Text = f_plane.ToString("F0");
            var regValue = System.BitConverter.GetBytes(f_plane);
            if (deusEx != null)
                deusEx.SetValue("g_stereoPlane", regValue);
            if (deusExDC != null)
                deusExDC.SetValue("g_stereoPlane", regValue);
        }

        private void monButton_Click(object sender, EventArgs e)
        {
            float monFloat;
            if (float.TryParse(tb_monSize.Text.Replace('.',','), out monFloat))
            {
                f_monSize = monFloat;
                strengthChange();
            }
        }
    }
}
