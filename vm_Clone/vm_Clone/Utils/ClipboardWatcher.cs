﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace vm_Clone
{
    class ClipboardWatcher : Form
    {
        static IntPtr nextClipboardViewer;

        public delegate void OnClipboardChangeEventHandler(ClipboardFormat format, object data, string type);
        public event OnClipboardChangeEventHandler OnClipboardChange;

        public void Start()
        {
            CreateHandle();
            nextClipboardViewer = SetClipboardViewer(this.Handle);
        }


        // stop listening (dispose form)
        public void Stop()
        {
            ChangeClipboardChain(this.Handle, nextClipboardViewer);
            this.Close();
            this.Dispose();
        }

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        // defined in winuser.h
        const int WM_DRAWCLIPBOARD = 0x308;
        const int WM_CHANGECBCHAIN = 0x030D;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    ClipChanged();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        static readonly string[] formats = Enum.GetNames(typeof(ClipboardFormat));

        static public void ClipChanged(OnClipboardChangeEventHandler handler, string type)
        {
            IDataObject iData = Clipboard.GetDataObject();

            ClipboardFormat? format = null;

            foreach (var f in formats)
            {
                if (iData.GetDataPresent(f))
                {
                    format = (ClipboardFormat)Enum.Parse(typeof(ClipboardFormat), f);
                    break;
                }
            }

            object data = iData.GetData(format.ToString());

            if (data == null || format == null)
                return;

                handler((ClipboardFormat)format, data, type);
        }


        private void ClipChanged()
        {
            IDataObject iData = Clipboard.GetDataObject();

            ClipboardFormat? format = null;

            foreach (var f in formats)
            {
                if (iData.GetDataPresent(f))
                {
                    format = (ClipboardFormat)Enum.Parse(typeof(ClipboardFormat), f);
                    break;
                }
            }

            object data = iData.GetData(format.ToString());

            if (data == null || format == null)
                return;

            if (OnClipboardChange != null)
                OnClipboardChange((ClipboardFormat)format, data, null);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClipboardWatcher
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ClipboardWatcher";
            this.Load += new System.EventHandler(this.ClipboardWatcher_Load);
            this.ResumeLayout(false);

        }

        private void ClipboardWatcher_Load(object sender, EventArgs e)
        {

        }
    }

    public enum ClipboardFormat : byte
    {
        /// <summary>Specifies the standard ANSI text format. This static field is read-only.
        /// </summary>
        /// <filterpriority>1</filterpriority>
        Text,
        /// <summary>Specifies the standard Windows Unicode text format. This static field
        /// is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        UnicodeText,
        /// <summary>Specifies the Windows device-independent bitmap (DIB) format. This static
        /// field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Dib,
        /// <summary>Specifies a Windows bitmap format. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Bitmap,
        /// <summary>Specifies the Windows enhanced metafile format. This static field is
        /// read-only.</summary>
        /// <filterpriority>1</filterpriority>
        EnhancedMetafile,
        /// <summary>Specifies the Windows metafile format, which Windows Forms does not
        /// directly use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        MetafilePict,
        /// <summary>Specifies the Windows symbolic link format, which Windows Forms does
        /// not directly use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        SymbolicLink,
        /// <summary>Specifies the Windows Data Interchange Format (DIF), which Windows Forms
        /// does not directly use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Dif,
        /// <summary>Specifies the Tagged Image File Format (TIFF), which Windows Forms does
        /// not directly use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Tiff,
        /// <summary>Specifies the standard Windows original equipment manufacturer (OEM)
        /// text format. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        OemText,
        /// <summary>Specifies the Windows palette format. This static field is read-only.
        /// </summary>
        /// <filterpriority>1</filterpriority>
        Palette,
        /// <summary>Specifies the Windows pen data format, which consists of pen strokes
        /// for handwriting software, Windows Forms does not use this format. This static
        /// field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        PenData,
        /// <summary>Specifies the Resource Interchange File Format (RIFF) audio format,
        /// which Windows Forms does not directly use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Riff,
        /// <summary>Specifies the wave audio format, which Windows Forms does not directly
        /// use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        WaveAudio,
        /// <summary>Specifies the Windows file drop format, which Windows Forms does not
        /// directly use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        FileDrop,
        /// <summary>Specifies the Windows culture format, which Windows Forms does not directly
        /// use. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Locale,
        /// <summary>Specifies text consisting of HTML data. This static field is read-only.
        /// </summary>
        /// <filterpriority>1</filterpriority>
        Html,
        /// <summary>Specifies text consisting of Rich Text Format (RTF) data. This static
        /// field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Rtf,
        /// <summary>Specifies a comma-separated value (CSV) format, which is a common interchange
        /// format used by spreadsheets. This format is not used directly by Windows Forms.
        /// This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        CommaSeparatedValue,
        /// <summary>Specifies the Windows Forms string class format, which Windows Forms
        /// uses to store string objects. This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        StringFormat,
        /// <summary>Specifies a format that encapsulates any type of Windows Forms object.
        /// This static field is read-only.</summary>
        /// <filterpriority>1</filterpriority>
        Serializable,
    }
}
