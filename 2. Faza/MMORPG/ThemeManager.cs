using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MMORPG
{
    public class ThemeManager
    {
        // Paleta boja (možeš lako menjati po želji)
        private static Color PrimaryBackground = Color.FromArgb(61, 31, 13);   
        private static Color SecondaryBackground = Color.FromArgb(150, 60, 8); 
        private static Color AccentColor = Color.Goldenrod;                    // zlatna
        private static Color TextColor = Color.Gainsboro;                      // sivo-bela
        private static Color DisabledTextColor = Color.DimGray;

        // Osnovni font
        private static Font DefaultFont = new Font("Segoe UI", 11, FontStyle.Regular);
        private static Font TitleFont = new Font("Segoe UI", 14, FontStyle.Bold);

        //Stilizovanje forme
        public static void ApplyTheme(Form form)
        {
            form.BackColor = PrimaryBackground;
            form.ForeColor = TextColor;
            form.Font = DefaultFont;

            ApplyThemeToControls(form.Controls);
        }

        //Stilizovanje svih kontrola
        private static void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = SecondaryBackground;
                    btn.ForeColor = AccentColor;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80);
                    btn.Font = TitleFont;
                }
                else if (ctrl is Label lbl)
                {
                    lbl.ForeColor = TextColor;
                    lbl.Font = DefaultFont;
                }
                else if (ctrl is TextBox txt)
                {
                    txt.BackColor = SecondaryBackground;
                    txt.ForeColor = TextColor;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is ComboBox cb)
                {
                    cb.BackColor = SecondaryBackground;
                    cb.ForeColor = TextColor;
                    cb.FlatStyle = FlatStyle.Flat;
                }
                else if (ctrl is ListView lv)
                {
                    lv.BackColor = SecondaryBackground;
                    lv.ForeColor = TextColor;
                    lv.BorderStyle = BorderStyle.None;
                }
                else
                {
                    ctrl.BackColor = PrimaryBackground;
                    ctrl.ForeColor = TextColor;
                }

                // Ako ima unutrašnjih kontrola (paneli, groupbox, itd.)
                if (ctrl.HasChildren)
                    ApplyThemeToControls(ctrl.Controls);
            }
        }
    }
}
