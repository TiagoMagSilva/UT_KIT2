using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;




namespace UT_KIT2
{
    public partial class Form1 : Form
    {        
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEY_ID = 1;




        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

        private const UInt32 MouseEventLeftDown = 0x0002;
        private const UInt32 MouseEventLeftUp = 0x0004;

        int X_POS = 0, Y_POS = 0;

        int index_Row_DGV = 0;

        public Form1()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int)Keys.F11);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                Timer_AtrasoInicio.Enabled = false;
                Timer_EntreClicks.Enabled = false;
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Iniciar.Enabled = false;
            //int xPos = 500, yPos = 500;
            //SetCursorPos(xPos, yPos);//Call this when you want to set the mouse position
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Z)
            {                
                X_POS = Cursor.Position.X;
                Y_POS = Cursor.Position.Y;
                DGV_Clicks.Rows.Add(DGV_Clicks.Rows.Count, X_POS, Y_POS);
                DGV_Clicks.FirstDisplayedScrollingRowIndex = DGV_Clicks.RowCount - 1;
                btn_Iniciar.Enabled = true;
            }
            if (e.KeyChar == (char)Keys.A)
            {
                //SetCursorPos(X_POS, Y_POS);
            }
            if (e.KeyChar == (char)Keys.C)
            {
                //SendLeftClick();
            }
            if (e.KeyChar == (char)Keys.S)
            {
                //Timer_AtrasoInicio.Enabled = false;
                //Timer_EntreClicks.Enabled = false;                
            }
            if (e.KeyChar == (char)Keys.F)
            {
                //Application.Exit();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DGV_Clicks.Rows.Clear();
            btn_Iniciar.Enabled = false;
        }

        private void TB_TempoAtraso_Scroll(object sender, EventArgs e)
        {
            txt_TempoAtraso.Text = TB_TempoAtraso.Value + " (s)";
        }

        private void TB_Intervalo_Scroll(object sender, EventArgs e)
        {
            txt_Intervalo.Text = TB_Intervalo.Value + " (ms)";
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            if(TB_TempoAtraso.Value > 0)
            {
                Timer_AtrasoInicio.Interval = TB_TempoAtraso.Value * 1000;
                Timer_AtrasoInicio.Enabled = true;
            }
            else
            {
                Timer_EntreClicks.Interval = TB_Intervalo.Value;
                Timer_EntreClicks.Enabled = true;
            }            
        }

        private void Timer_AtrasoInicio_Tick(object sender, EventArgs e)
        {
            Timer_AtrasoInicio.Enabled = false;
            Timer_EntreClicks.Interval = TB_Intervalo.Value;
            Timer_EntreClicks.Enabled = true;
        }

        private void Timer_EntreClicks_Tick(object sender, EventArgs e)
        {
            if(DGV_Clicks.Rows.Count > 0 && index_Row_DGV < DGV_Clicks.Rows.Count - 1)
            {
                if(DGV_Clicks.Rows[index_Row_DGV].Cells[1].Value.ToString() == "Enter")
                {
                    SendKeys.Send("{ENTER}");
                    index_Row_DGV++;
                }
                else
                {
                    SetCursorPos((int)DGV_Clicks.Rows[index_Row_DGV].Cells[1].Value, (int)DGV_Clicks.Rows[index_Row_DGV].Cells[2].Value);
                    SendLeftClick();
                    index_Row_DGV++;
                }                                
            }
            if (index_Row_DGV >= DGV_Clicks.Rows.Count - 1)
                index_Row_DGV = 0;
        }

        private void LBL_Help_Click(object sender, EventArgs e)
        {
            string texto = "As teclas de atalho são todas maiúsculas.\r\n" +
                "Z - Incluir novo ponto\r\n" +
                "Fn + F11 - Pausar simulação\r\n";
            MessageBox.Show(texto, "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddEnter_Click(object sender, EventArgs e)
        {
            DGV_Clicks.Rows.Add(DGV_Clicks.Rows.Count, "Enter", "Enter");
            DGV_Clicks.FirstDisplayedScrollingRowIndex = DGV_Clicks.RowCount - 1;
        }

        private void SendLeftClick()
        {
            mouse_event(MouseEventLeftDown, 0, 0, 0, new System.IntPtr());
            mouse_event(MouseEventLeftUp, 0, 0, 0, new System.IntPtr());
        }

    }
}
